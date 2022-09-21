using CenterManager.Control.DBControl;
using CenterManager.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.Control.Presenters
{
    internal class EditSubjectPresenter
    {
        EditSubjectInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        Subject model = new Subject();
        public EditSubjectPresenter(EditSubjectInterFace i)
        {
            interFace = i;
            Refresh();
        }
        internal void Refresh()
        {
            interFace.ClassesDataSource = db.Subjects.Select(x => new { Subject_Name = x.Name, ID = x.ID }).ToList();
        }

        internal void AddClass()
        {

            model.Name = interFace.Class_Name;
            db.Subjects.Add(model);
            db.SaveChanges();
            db.Entry(model).State = EntityState.Modified;
            Refresh();
        }

        internal void EditClass()
        {
            model = db.Subjects.SingleOrDefault(x => x.ID == interFace.id);
            model.Name = interFace.Class_Name;
            db.SaveChanges();
            Refresh();
        }

        public static void DeleteClass(int id)
        {
            CenterManagerEntities db = Methods.Methods.db;
            Subject s = db.Subjects.SingleOrDefault(x => x.ID == id);
            
            db.Subjects.Remove(s);
            db.SaveChanges();
            
        }
         
        public static void DeleteAllClasses()
        {
            CenterManagerEntities db = Methods.Methods.db;
            db.Books.RemoveRange(db.Books);
            db.Subjects.RemoveRange(db.Subjects);
            db.SaveChanges();
            
            
        }

        internal void Search()
        {
            interFace.ClassesDataSource = db.Subjects.Where(x => x.Name.Contains(interFace.Search)).Select(a=>new {ID = a.ID , Subject_Name = a.Name }).ToList();
        }
    }
}
