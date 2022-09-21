using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CenterManager.Control.Presenters
{
    public class ViewStudentsPresenter
    {
        ViewStudentsInterFace interFace; 
        CenterManagerEntities db = Methods.Methods.db;
        public ViewStudentsPresenter(ViewStudentsInterFace i ,int mode) {
            interFace = i;
            UpdateData();
        }
         public void UpdateData() {
            /*interFace.StudentDataSource = db.Students.Join(db.Classes,cl => cl.ClassID , c=> c.ID,(s,c)=> new {
                ID = s.ID,
                STCode = s.STCode,
                Name = s.Name,
                ST_Phone = s.ST_Phone,
                Address = s.Address,
                Parent_Number = s.Parent_Number,
                Is_for_Contact = s.Is_for_Contact? "✔": "✖",
                IsMale = s.IsMale ? "ذكر":"انثى",
                ClassID = c.Class_Name,
                School =s.School,
                Study_Level = s.Study_Level == 0 ? "عام" : s.Study_Level == 1 ? "علمى رياضه" : s.Study_Level == 2 ? "علمى علوم" : "ادبى",
                Discount = s.Discount
            }).ToList();
           // interFace.StudentDataSource = db.Students.ToList();*/

            interFace.StudentDataSource = db.Students.Select(s=>
            new {
                ID = s.ID,
                STCode = s.STCode,
                Name = s.Name,
                ST_Phone = s.ST_Phone,
                Address = s.Address,
                Parent_Number = s.Parent_Number,
                Is_for_Contact = s.Is_for_Contact ? "✔" : "✖",
                IsMale = s.IsMale ? "ذكر" : "انثى",
                ClassID = s.Class.Class_Name,
                School = s.School,
                Study_Level = s.Study_Level == 0 ? "عام" : s.Study_Level == 1 ? "علمى رياضه" : s.Study_Level == 2 ? "علمى علوم" : "ادبى",
                Discount = s.Discount
            }).ToList();
        }

        public static void Delete(int id)
        {
            CenterManagerEntities db = Methods.Methods.db;
            db.Attendances.RemoveRange(db.Attendances.Where(s => s.StudentID == id));
            db.StudentsGroups.RemoveRange(db.StudentsGroups.Where(s => s.STID == id));
            db.StudentBooks.RemoveRange(db.StudentBooks.Where(s => s.STID == id));
            db.Students.Remove(db.Students.SingleOrDefault(z => z.ID == id));
            db.StudentExams.RemoveRange(db.StudentExams.Where(a => a.STID == id));
            db.SaveChanges();
        }
        public IQueryable<Student> GetAll()
        {
            return db.Students;
        }
        public void DeleteAll()
        {
            DeleteMethods.DeleteAllStudents();
        } 

        internal void Search()
        {
           interFace.StudentDataSource = db.Students
                .Where(x=>x.Name== interFace.Search || x.STCode.ToString() == interFace.Search || x.Class.Class_Name == interFace.Search)
                .Select(s=>new {
                    ID = s.ID,
                    STCode = s.STCode,
                    Name = s.Name,
                    ST_Phone = s.ST_Phone,
                    Address = s.Address,
                    Parent_Number = s.Parent_Number,
                    Is_for_Contact = s.Is_for_Contact ? "✔" : "✖",
                    IsMale = s.IsMale ? "ذكر" : "انثى",
                    ClassID = s.Class.Class_Name,
                    School = s.School,
                    Study_Level = s.Study_Level == 0 ? "عام" : s.Study_Level == 1 ? "علمى رياضه" : s.Study_Level == 2 ? "علمى علوم" : "ادبى",
                    Discount = s.Discount
                }).ToList();
        }
    }
}
