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
    internal class AddGroupPresenter
    {
        AddGroupInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        Group model;
        Action action;
        int id = 0;
        public AddGroupPresenter(AddGroupInterFace i, int id)
        {
            this.id = id;
            interFace = i;
            LoadClasses();
            LoadSubjects();
            if (id == 0)
            {
                action = AddGroup;
                model = new Group();
                Clear();
            }
            else
            {
                action = UpdateGroup;
                model = db.Groups.SingleOrDefault(x => x.ID == id);
                LoadDataToScreen();
            }
        }

        private void LoadSubjects()
        {
            interFace.SubjectDataSource = db.Subjects.ToList();
        }

        void LoadClasses()
        {
            interFace.ClassDataSource = db.Classes.ToList();
        }

        void LoadDataToScreen()
        {
            
            interFace.GroupName = model.Name;
            interFace.YearStart = model.StartDate;
            interFace.YearEnd = model.EndDate;
            interFace.Class = (int)model.ClassID;
            interFace.FromTime = model.FromHour;
            interFace.ToTime = model.ToHour;
            interFace.Price = float.Parse(model.Price.ToString());
            interFace.IsActive = model.IsActive;
            interFace.Sat = model.Saturday;
            interFace.Sun = model.Sunday;
            interFace.Mon = model.Monday;
            interFace.Tues = model.Tuesday;
            interFace.Wed = model.Wednesday;
            interFace.Thurs = model.Thursday;
            interFace.Fri = model.Friday;
            interFace.Note = model.Note;
            interFace.Subject = model.SubjectID; 
        }
        void ConnectModelInterFace()
        {
            model.Name = interFace.GroupName;
            model.StartDate = interFace.YearStart;
            model.EndDate = interFace.YearEnd;
            model.ClassID = interFace.Class;
            model.FromHour = interFace.FromTime;
            model.ToHour = interFace.ToTime;
            model.Price = interFace.Price;
            model.IsActive = interFace.IsActive;
            model.Saturday = interFace.Sat;
            model.Sunday = interFace.Sun;
            model.Monday = interFace.Mon;
            model.Tuesday = interFace.Tues;
            model.Wednesday = interFace.Wed;
            model.Thursday = interFace.Thurs;
            model.Friday = interFace.Fri;
            model.Note = interFace.Note;
            model.SubjectID = interFace.Subject; 
        }
        void AddGroup()
        {
            ConnectModelInterFace();
            db.Groups.Add(model);
            db.SaveChanges();
            MessageBox.Show("تم الاضافه بنجاح");
            Clear();
        }

        private void Clear()
        {
            interFace.GroupName = "";
            interFace.YearStart = DateTime.Now;
            interFace.YearEnd = DateTime.Now.AddYears(1);

            interFace.FromTime = DateTime.Now.ToString();
            interFace.ToTime = DateTime.Now.ToString();

            interFace.Class = 0;
            interFace.IsActive = true;
            interFace.Note = "";
            interFace.Sat = false;
            interFace.Sun = false;
            interFace.Mon = false;
            interFace.Tues = false;
            interFace.Wed = false;
            interFace.Thurs = false;
            interFace.Fri = false;
            interFace.SelectedClass = 0;
        }

        void UpdateGroup()
        {
            ConnectModelInterFace();
            db.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح");
        }
        internal void Execute()
        {
            action.Invoke();
        }
    }
}
