using CenterManager.Control.DBControl;
using CenterManager.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CenterManager.Control.Presenters
{
    internal class AddBookPresenter
    {
        AddBookInterFace interFace;
        Action action;
        CenterManagerEntities db = Methods.Methods.db;
        Book model = new Book();
        int id = -1;
        public AddBookPresenter(AddBookInterFace i, int ID)
        {
            interFace = i;
            id = ID;
            UpdateClasses();
            UpdateSubjects();
            if (id == 0)
            {
                action = Add;
            }
            else
            {
                model = db.Books.SingleOrDefault(x => x.ID == id);
                action = Update;
                LoadDataToInterFace();
            }
        }

        private void LoadDataToInterFace()
        {
            interFace.BookName = model.Name;
            interFace.ClassID = (int)model.Class;
            interFace.PriceForST = (float)model.Price_for_St;
            interFace.Price = (float)model.Price;
            interFace.Earnings = (float)model.Total;
            interFace.SubjectID = model.SubjectID;
            interFace.Note = model.Note;
            interFace.Quantity = model.Quantity;
        }

        void UpdateClasses()
        {
            interFace.ClassDataSource = db.Classes.Select(x => new { x.ID, x.Class_Name }).ToList();
        }
        void UpdateSubjects()
        {
            interFace.SubjectDataSource = db.Subjects.Select(a => new { a.ID, a.Name }).ToList();
        }
        public void Clear()
        {
            interFace.BookName = "";
            interFace.SelectedClassID = 0;
            interFace.PriceForST = 0;
            interFace.Price = 0;
            interFace.Earnings = 0;
            interFace.SubjectID = 0;
            interFace.Note = "";
            interFace.Quantity = 1;
        }
        void Update()
        {
            ConnectModelInterFace();
            db.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح");
        }
        void ConnectModelInterFace()
        {
            model.Name = interFace.BookName;
            model.Quantity = interFace.Quantity; 
            model.Class = interFace.ClassID;
            model.Price_for_St = interFace.PriceForST;
            model.Price = interFace.Price;
            model.Total = interFace.Earnings;
            model.SubjectID = interFace.SubjectID;
            model.Note = interFace.Note;
        }
        void Add()
        {
            try
            {
                ConnectModelInterFace();
                if (db.Books.SingleOrDefault(a => a.Name == interFace.BookName) == null)
                {
                    db.Books.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("تم الاضافه بنجاح");
                    Clear();
                }
                else MessageBox.Show("اسم الكتاب ماخوذ من قبل");
                
            }
            catch { }
        }
        internal void Execute()
        {
            action.Invoke();
        }
    }
}
