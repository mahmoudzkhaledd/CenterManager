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
    internal class ViewAttendancePresenter
    {
        ViewAttendanceInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        Attendance model = new Attendance();
        int filter = 0; // 0 for absent 1 for attend 2 fro all students
        public ViewAttendancePresenter(ViewAttendanceInterFace i) {
            interFace = i;
            UpdateGroups();
            UpdateLecs();
        }
         
        public void UpdateLecs()
        {
            /* interFace.LecDataSource = 
                 db.Attendances.Where(x=>x.GroupID == interFace.GroupID)
                 .Select(x=>new {Data = x.AttendanceID.ToString() + " : " + x.Date.ToString(), LecID = x.AttendanceID })
                 .Distinct()
                 .ToList();*/
            interFace.LecDataSource =
                db.Attendances.Where(a => a.GroupID == interFace.GroupID)
                .Select(x=>new {
                    Data = x.Lecture.LecNumber.ToString() + " : " + x.Lecture.Date.ToString(),
                    LecID = x.LecID
                }).Distinct().ToList();
        }

        public void UpdateGroups()
        {
            interFace.GroupsDataSource = db.Groups.Select(x =>new {Name = x.Name,ID = x.ID }).ToList();
        }

        public void UpdateStudents()
        {
            filter = 2;
            interFace.StudentsDataSource = db.Attendances.Where(x => x.LecID == interFace.LecID && x.GroupID == interFace.GroupID)
                .Select(x => new {
                ID = x.Student.ID,
                STDCode = x.Student.STCode,
                STDName = x.Student.Name,
                Attend = x.Attend ? "✔" : "❌"
            }).ToList();
        }

        internal void MakeAttend(int id ,bool attend)
        {
            model = db.Attendances.SingleOrDefault(x => x.LecID == interFace.LecID
            && x.GroupID == interFace.GroupID && x.StudentID == id);
            model.Attend = attend;
            db.SaveChanges();
            if (filter == 2)
                UpdateStudents();
            else FilterStudentAttendance(filter == 1);
        }

        internal void Search()
        {
           if(filter == 2) {
                interFace.StudentsDataSource = db.Attendances.Where(x => x.LecID == interFace.LecID && x.GroupID == interFace.GroupID)
              .Select(x => new {
                  ID = x.Student.ID,
                  STDCode = x.Student.STCode,
                  STDName = x.Student.Name,
                  Attend = x.Attend ? "✔" : "❌"
              }).Where(x =>
              x.STDCode.ToString().Contains(interFace.Search)
              || x.STDName.Contains(interFace.Search)
              ).ToList();
            }
            else
            {
                interFace.StudentsDataSource = db.Attendances.Where(x => x.LecID == interFace.LecID && x.GroupID == interFace.GroupID)
                .Select(x => new {
                  ID = x.Student.ID,
                  STDCode = x.Student.STCode,
                  STDName = x.Student.Name,
                  Attend = x.Attend ? "✔" : "❌"
              }).Where(x => (x.STDCode.ToString().Contains(interFace.Search)
              || x.STDName.Contains(interFace.Search)) && x.Attend == ((filter == 0) ? "❌" : "✔")
              ).ToList();
            }
        }

        internal void FilterStudentAttendance(bool v)
        {
            string a = v ? "✔" : "❌";
            filter = v ? 1 : 0;
            interFace.StudentsDataSource = db.Attendances.Where(x => x.LecID == interFace.LecID && x.GroupID == interFace.GroupID)
               .Select(x => new {
                   ID = x.Student.ID,
                   STDCode = x.Student.STCode,
                   STDName = x.Student.Name,
                   Attend = x.Attend ? "✔" : "❌",
               }).Where(x => x.Attend == a).ToList();
        }

        public static void DeleteLec(int id)
        {
            CenterManagerEntities db = Methods.Methods.db;
            //db.Attendances.RemoveRange(db.Attendances.Where(x=>x.LecID == interFace.LecID && x.GroupID == interFace.GroupID));
            db.Lectures.RemoveRange(db.Lectures.Where(a=> a.ID == id));
            
            db.SaveChanges();
            
        }
    }
}
