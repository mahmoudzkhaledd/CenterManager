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
    public class AddStudentPresenter
    {
        AddStudentInterFace interFace;
        Student model = null;
        CenterManagerEntities db = Methods.Methods.db;
        Action action;
        int id = 0;
        public AddStudentPresenter(AddStudentInterFace interFace, int ii)
        {
            id = ii;
            this.interFace = interFace;
            LoadClass();
            if (id == 0)
            {
                action = AddStudent;
                model = new Student();
                Clear();
                interFace.SelectedClass = 0;
                GetNextSTCode();
            }
            else
            {
                action = UpdateStudent;
                model = db.Students.SingleOrDefault(a => a.ID == id);
                LoadDataToInterface();
            }
        }
        void GetNextSTCode() {
            try { interFace.STCode = db.Students.Select(x => x.STCode).Max() + 1; } catch { interFace.STCode = 1000; }
        }
        void LoadDataToInterface()
        {
            interFace.STName = model.Name;
            interFace.STCode = model.STCode;
            interFace.isMale = model.IsMale;
            interFace.StClass = (int)model.ClassID;
            interFace.PhoneNumber = model.ST_Phone;
            interFace.Address = model.Address;
            interFace.ParentNumber = model.Parent_Number;
            interFace.IsForContact = model.Is_for_Contact;
            interFace.School = model.School;
            interFace.Type = model.Study_Level;
            interFace.discount = model.Discount;
        }
        void LoadClass()
        { 
            interFace.ClassDataSource = db.Classes.ToList();
        }
        public void Clear()
        {
            interFace.STName = "";

            interFace.isMale = true;
            interFace.PhoneNumber = "";
            interFace.Address = "";
            interFace.ParentNumber = "";
            interFace.IsForContact = false;
            interFace.School = "";
            interFace.discount = 0;
            interFace.Type = 0;
            interFace.SelectedClass = 0;
        }
        void ConnectModelInterFace()
        {
            model.Name = interFace.STName;
            model.STCode = interFace.STCode;
            model.IsMale = interFace.isMale;
            model.ClassID = interFace.StClass;
            model.ST_Phone = interFace.PhoneNumber;
            model.Address = interFace.Address;
            model.Parent_Number = interFace.ParentNumber;
            model.Is_for_Contact = interFace.IsForContact;
            model.School = interFace.School;
            model.Discount = interFace.discount;
            model.Study_Level = byte.Parse(interFace.Type.ToString());
        }
        public void AddStudent()
        {
            ConnectModelInterFace();
            try
            {
                db.Students.Add(model);
                db.SaveChanges();
                MessageBox.Show("تم الاضافه بنجاح");
                Clear();
                GetNextSTCode();
            }
            catch (Exception ex)
            {
                if (ex.Message == "An error occurred while updating the entries. See the inner exception for details.")
                    MessageBox.Show("كود الطالب موجود من قبل");
            }
        }
        public void UpdateStudent()
        {
            try {
                ConnectModelInterFace();
                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            } catch (Exception ex)
            {
                if (ex.Message == "An error occurred while updating the entries. See the inner exception for details.")
                    MessageBox.Show("كود الطالب موجود من قبل");
            }
        }
        public void Execute() => action.Invoke();

    }
}
