using CenterManager.Control.DBControl;
using CenterManager.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.Control.Presenters
{
    internal class StudentBookPresenter
    {
        StudentBookInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        
        public StudentBookPresenter(StudentBookInterFace i) {
            interFace = i;
            interFace.BooksDataSource = db.Books.Select((x) => new { BookName = x.Name, ID = x.ID }).ToList();
            GetData();
        }
        public void GetStudents()
        {
            interFace.StudentsDataSource = db.StudentsGroups.Where(a => a.Student.ClassID == interFace.ClassID && a.Group.SubjectID == interFace.SubjectID)
                .Select(a=>new { a.Student.ID,a.Student.STCode ,a.Student.Name}).ToList();
        }
        public void GetData()
        {
            Book b = db.Books.SingleOrDefault(a => a.ID == interFace.SelectedBookID);
            interFace.ClassName = b.Class1.Class_Name;
            interFace.SubjectName = b.Subject.Name;
            interFace.ClassID = b.Class1.ID;
            interFace.SubjectID = b.SubjectID;
        }
        public void Remove(int id) {
            db.StudentBooks.Remove(db.StudentBooks.FirstOrDefault(a=>a.STID == id && a.BookID == interFace.SelectedBookID));
            db.SaveChanges();
            ShowStudentsHaveBook();
        }
        internal void Add(int STID)
        {
            StudentBook model = new StudentBook();
            model.BookID =interFace.SelectedBookID;
            model.STID = STID;
            db.StudentBooks.Add(model);
            db.SaveChanges();
        }

        internal void ShowNumber()
        {
            interFace.Number = db.StudentBooks.Where(a => a.BookID == interFace.SelectedBookID).Count();
        }

        internal void ShowStudentsHaveBook()
        {
            interFace.StudentsDataSource = db.StudentBooks.Where(a => a.BookID == interFace.SelectedBookID)
                .Select(x => 
                new { 
                    x.Student.ID,
                    x.Student.STCode,
                    x.Student.Name
                }).ToList();
        }
    }
}
