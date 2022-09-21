using CenterManager.Control.DBControl;
using CenterManager.View;
using CenterManager.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CenterManager.Control.Presenters
{
    public class EditStudentsPresenter
    {
        ClassesInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        Class model = new Class();
        public EditStudentsPresenter (ClassesInterFace i) {
            interFace = i;
            Refresh();
        }
        internal void Refresh() {
            interFace.ClassesDataSource = db.Classes.Select(x => new{ Class_Name = x.Class_Name , ID =x.ID}).ToList();
        }

        internal void AddClass(){
            
            model.Class_Name = interFace.Class_Name;
            db.Classes.Add(model);
            db.SaveChanges();
            db.Entry(model).State = EntityState.Modified;
            Refresh();
        }

        internal void EditClass() {
            model = db.Classes.SingleOrDefault(x => x.ID == interFace.id);
            model.Class_Name = interFace.Class_Name;
            db.SaveChanges();
            Refresh();
        }

        internal void DeleteClass(){
            db.Classes.Remove(db.Classes.SingleOrDefault(x=> x.ID == interFace.id));
            db.Students.RemoveRange(db.Students.Where(x => x.ClassID == interFace.id));
            db.Groups.RemoveRange(db.Groups.Where(x=>x.ClassID == interFace.id));
            db.SaveChanges();

            //db.Entry(model).State = EntityState.Modified;
            Refresh();
        }

        internal void DeleteAllClasses() {
            db.Classes.RemoveRange(db.Classes);
            db.Students.RemoveRange(db.Students);
            db.SaveChanges();
            db.Entry(model).State = EntityState.Modified;
            Refresh();
        }

        internal void Search()
        {
            interFace.ClassesDataSource = db.Classes.Where(x=>x.Class_Name.Contains(interFace.Search)).Select(a=>new {a.ID , a.Class_Name }).ToList();
        }
    }
}
