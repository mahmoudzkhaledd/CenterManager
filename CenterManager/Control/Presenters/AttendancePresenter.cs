using CenterManager.Control.DBControl;
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
    internal class AttendancePresenter
    {
        AttendanceInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        Attendance model = new Attendance();
        Lecture lModel = new Lecture();

        int LecID = 0;
        public AttendancePresenter(AttendanceInterFace i) {
            interFace = i;
        }
        public void GenerateLecID() {
            try {
                LecID = db.Attendances.Where(x => x.GroupID == interFace.GroupID).Select(x => x.Lecture.LecNumber).Max() + 1;
            }
            catch { 
                LecID = 1;
            }
            interFace.LecID = LecID;
        }

        internal void MakeLec()
        {
            try
            {
                GenerateLecID();
                interFace.CurrentLec = LecID.ToString();
                lModel.LecNumber = LecID;
                lModel.Date = DateTime.Now.ToString();
                db.Lectures.Add(lModel);
                db.SaveChanges();
            }
            catch { }
        }

        public void PrimaryAddStudent() { 
            
        }
        public void ShowAllStudents() 
        {
            /*interFace.StudentDataSource = db.StudentsGroups.Where((x) => x.GroupID == interFace.GroupID)
                .Join(db.Students, x => x.STID, s => s.ID,
                (x, s) => new {
                    ID = s.ID,
                    STCode = s.STCode,
                    Name = s.Name
                }
            ).ToList();*/
            interFace.StudentDataSource = db.StudentsGroups.Where((x) => x.GroupID == interFace.GroupID)
                .Select(x => new { 
                    ID = x.Student.ID,
                    STCode = x.Student.STCode,
                    Name = x.Student.Name 
                }
            ).ToList();
        }

        internal void Add(int id, bool att)
        {
            try
            {
                model.LecID = lModel.ID;
                model.GroupID = interFace.GroupID;
                model.StudentID = id;
                model.Attend = att;
                db.Attendances.Add(model);
                db.SaveChanges();
            }
            catch { }
        }

        internal void ShowStudentsNumber()
        {
            interFace.StudentNumber 
                = db.Attendances.Where(x => x.LecID == interFace.LecID && x.GroupID == interFace.GroupID && x.Attend).Count();
        }

        internal void Update(int id, bool attend) {
            
            model = db.Attendances.SingleOrDefault(x => x.LecID == lModel.ID  
            && x.GroupID == interFace.GroupID && x.StudentID == id);
            model.Attend = attend;
            db.SaveChanges();
        }
    }
}
