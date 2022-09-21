using CenterManager.Control.DBControl;
using CenterManager.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
namespace CenterManager.Control.Presenters
{ 
    internal class AddStudentGroupPresenter
    {
        AddStudentGroupInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        StudentsGroup model = new StudentsGroup();

        public AddStudentGroupPresenter(AddStudentGroupInterFace i) {
            interFace = i;
            UpdateGroup();
            GetClass();
            ShowAllStudents();
            ShowStudentNumber();
        }
        void UpdateGroup() {
            interFace.GroupsDataSource = db.Groups.Select((x) => new { GroupName = x.Name, ID = x.ID })
                .ToList();
        }
        public void ShowAllStudents() {
            /*interFace.StudentDataSource = db.Students.Where(a=>a.ClassID == interFace.ClassID)
                .Join(db.Classes, s => s.ClassID, c => c.ID,
                (s, c) => new {
                    ID = s.ID,
                    STCode = s.STCode,
                    Name = s.Name,
                    ClassID = c.Class_Name
                }
            ).ToList();*/
            interFace.StudentDataSource = db.Students.Where(a => a.ClassID == interFace.ClassID)
                .Select(x => new {
                    OPID = 1,
                    STID = x.ID ,
                    STCode = x.STCode , 
                    Name = x.Name , 
                    ClassID = x.Class.Class_Name
                }).ToList();
        }
        public void GetClass()
        {
            try
            {
                Group g = db.Groups.SingleOrDefault(a => a.ID == interFace.GroupID);
                if (g != null) {
                    interFace.ClassName = g.Class.Class_Name;
                    interFace.ClassID = g.Class.ID;
                }
            }
            catch { }
        }
        public void ShowStudentsInGroups() {
            /*interFace.StudentDataSource = db.StudentsGroups.Where((x) => x.GroupID == interFace.GroupID && x.Group.ClassID == interFace.ClassID)
                .Join(db.Students,x=>x.STID,s=>s.ID,
                (x,s)=>new {
                    ID = s.ID,
                    STCode = s.STCode,
                    Name = s.Name,
                    ClassID = s.ClassID
                }).Join(db.Classes,x=>x.ClassID , c=>c.ID ,
                (s,c)=>new {
                    ID = s.ID,
                    STCode = s.STCode,
                    Name = s.Name,
                    ClassID = c.Class_Name,
                }
           ).ToList();*/
            interFace.StudentDataSource = db.StudentsGroups
                .Where(x => x.GroupID == interFace.GroupID)
                .Select(a=>
                new {
                    OPID = a.ID,
                    STID = a.STID,
                    STCode = a.Student.STCode,
                    Name = a.Student.Name,
                    ClassID = a.Student.Class.Class_Name
                }).ToList();
        }
        internal void Add()
        {
            model.STID = interFace.STID;
            model.GroupID = interFace.GroupID;
            db.StudentsGroups.Add(model);
            db.SaveChanges();
            MessageBox.Show("تم الاضافه بنجاح");
            ShowStudentNumber();
            try { 
               
            } catch (Exception ex) {
                if (ex.Message == "An error occurred while updating the entries. See the inner exception for details.") {
                    MessageBox.Show($"الطالب موجود بالفعل فى المجموعه");
                }
            }
        }

        internal void ShowStudentNumber()
        {
            interFace.StudentNumber = db.StudentsGroups.Count(x=>x.GroupID == interFace.GroupID);
        }

        public static void Delete(int id)
        {
            CenterManagerEntities db = Methods.Methods.db;
            try 
            {
                db.StudentsGroups.Remove(db.StudentsGroups.SingleOrDefault(x => x.ID == id));
                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
            catch { }
        }

        internal void Search()
        {
            int code = -1;
            try { code = Convert.ToInt32(interFace.Search); } catch { }
            interFace.StudentDataSource = db.Students.Join(db.Classes, s => s.ClassID, c => c.ID,
                (s, c) => new
                {
                    ID = s.ID,
                    STCode = s.STCode,
                    Name = s.Name,
                    ClassID = c.Class_Name
                }
            ).Where(x=> x.STCode.ToString().Contains(code.ToString()) || x.Name.Contains(interFace.Search) || x.ClassID == interFace.Search).ToList();
           // IQueryable<Student> q = interFace.StudentDataSource as IQueryable<Student>;
            
           // interFace.StudentDataSource = q.Where(x => x.STCode.ToString().Contains(code.ToString())  || x.Name .Contains(interFace.Search)).ToList();
        }
    }
}
