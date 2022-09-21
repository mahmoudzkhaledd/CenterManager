using CenterManager.Control.DBControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.Control.Methods
{
    internal class DeleteMethods
    {
        public static CenterManagerEntities db = Methods.db;
        public static void DeleteStudent(int id) 
        {
            try { Student s = db.Students.SingleOrDefault(a=>a.ID == id);
            DeleteStudentBooks(s.StudentBooks);
            DeleteAttendances(s.Attendances);
            DeleteStudentGroups(s.StudentsGroups);
            DeleteStudentExams(s.StudentExams);
            db.Students.Remove(s);
            db.SaveChanges();} 
            catch { }
            
        }

        public static void DeleteStudents(ICollection<Student> s)
        {
            for (int i = 0; i < s.Count; i++) {
                DeleteStudent(s.ElementAt(i).ID);
            }
        }
        public static void DeleteAllStudents()
        {
            try
            {
                DeleteAllStudentBooks();
                DeleteAllAttendances();
                DeleteAllStudentGroups();
                DeleteAllStudentExams();
                db.Students.RemoveRange(db.Students);
                db.SaveChanges(); 
            }
            catch { }
           
        }
        public static void DeleteStudentBook(int id)
        {
            try {  StudentBook sb = db.StudentBooks.SingleOrDefault(a=>a.ID == id);
            db.StudentBooks.Remove(sb);
            db.SaveChanges();}
            catch { }
           
        }
        public static void DeleteStudentBooks(ICollection<StudentBook> sb)
        {
            for(int i = 0;i<sb.Count;i++) DeleteStudentBook(sb.ElementAt(i).ID);
        }
        public static void DeleteAllStudentBooks()
        {
            try {
                db.StudentBooks.RemoveRange(db.StudentBooks);
            db.SaveChanges(); 
            } 

            catch { }
            
        }

        public static void DeleteAttendance(int id)
        {
            try {Attendance a = db.Attendances.SingleOrDefault(s=>s.ID == id);
            DeleteLecture(a.LecID);
            db.Attendances.Remove(a);
            db.SaveChanges(); }
            catch { }
            
        }
        public static void DeleteAttendances(ICollection<Attendance> att)
        {
            foreach(Attendance attendance in att) DeleteAttendance(attendance.ID);
        }
        public static void DeleteAllAttendances()
        {
            try {DeleteAllLectures();
            db.Attendances.RemoveRange(db.Attendances);
            db.SaveChanges(); }
            catch { }
            
        }

        public static void DeleteStudentGroup(int id)
        {
            try {  
                db.StudentsGroups.Remove(db.StudentsGroups.SingleOrDefault(a=>a.ID == id));
                db.SaveChanges();
            }
            catch { }
           ;
        }
        public static void DeleteStudentGroups(ICollection<StudentsGroup> sg)
        {
            for (int i = 0; i < sg.Count; i++) DeleteStudentGroup(sg.ElementAt(i).ID);
        }
        public static void DeleteAllStudentGroups()
        {
            try { db.StudentsGroups.RemoveRange(db.StudentsGroups);
            db.SaveChanges();}
            catch { }
            
        }

        public static void DeleteStudentExam(int id)
        {
            try { db.StudentExams.Remove(db.StudentExams.SingleOrDefault(a=>a.ID == id));
                db.SaveChanges();
            }
            catch { }
            ;
        }
        public static void DeleteStudentExams(ICollection<StudentExam> se)
        {
            foreach (StudentExam e in se) DeleteStudentExam(e.ID);

        }
        public static void DeleteAllStudentExams()
        {
            try { db.StudentExams.RemoveRange(db.StudentExams);
            db.SaveChanges();}
            catch { }
            
        }
        public static void DeleteExam(int id)
        {
            try {Exam e = db.Exams.SingleOrDefault(a=>a.ID == id);
            DeleteStudentExams(e.StudentExams);
            DeleteExamDetails(e.ExamDetails);
            db.Exams.Remove(e);
            db.SaveChanges(); }
            catch { }
            
        }
        public static void DeleteExams(ICollection<Exam> e)
        {
            foreach(Exam ex in e) DeleteExam(ex.ID);
        }
        public static void DeleteAllExams()
        {
            try { DeleteAllStudentExams();
            DeleteAllExamDetails();
            db.Exams.RemoveRange(db.Exams);
            db.SaveChanges();}
            catch { }
            
        }
        public static void DeleteExamDetails(ICollection<ExamDetail> ed)
        {
            try {db.ExamDetails.RemoveRange(ed);
            db.SaveChanges(); }
            catch { }
            
        }
        public static void DeleteAllExamDetails()
        {
            try {db.ExamDetails.RemoveRange(db.ExamDetails);
            db.SaveChanges(); }
            catch { }
            
        }
        public static void DeleteBook(int id)
        {
            try {   Book b = db.Books.SingleOrDefault(a=>a.ID == id);
            DeleteStudentBooks(b.StudentBooks);
            db.Books.Remove(b); db.SaveChanges();
            }
            catch { }
          
        }
        public static void DeleteBooks(ICollection<Book> b)
        {
            for (int i = 0; i < b.Count; i++) DeleteBook(b.ElementAt(i).ID);
        }
        public static void DeleteAllBooks()
        {
            try {DeleteAllStudentBooks();
            db.Books.RemoveRange(db.Books);
            db.SaveChanges(); } 
            catch { }
            
        }
        public static void DeleteClass(int id)
        {
            try { Class c = db.Classes.SingleOrDefault(a=>a.ID == id);
            DeleteBooks(c.Books);
            DeleteStudents(c.Students);
            DeleteGroups(c.Groups);
            db.Classes.Remove(c);
            db.SaveChanges(); }
            catch { }
           
        }
        public static void DeleteClasses(ICollection<Class> c)
        {
            for (int i = 0; i < c.Count; i++) DeleteClass(c.ElementAt(i).ID);
        }
        public static void DeleteAllClasses()
        {
            try {
                DeleteAllBooks();
                DeleteAllStudents();
                DeleteAllGroups();
                db.Classes.RemoveRange(db.Classes); 
                db.SaveChanges();
            } catch { }
            
        }
        public static void DeleteSubject(int id)
        {
            try { Subject s = db.Subjects.SingleOrDefault(a=>a.ID == id);
            DeleteBooks(s.Books);
            DeleteGroups(s.Groups);
            db.Subjects.Remove(s);
            db.SaveChanges(); }
            catch { }
           
        }
        public static void DeleteSubjects(ICollection<Subject> su)
        {
            foreach(Subject s in su) DeleteSubject(s.ID);
        }
        public static void DeleteAllSubjects()
        {
            try
            {
                DeleteAllBooks();
                DeleteAllGroups(); 
                db.Subjects.RemoveRange(db.Subjects);
                db.SaveChanges();
            }
            catch { }
            
        }
        public static void DeleteLecture(int id)
        {
            try { 
                db.Lectures.RemoveRange(db.Lectures.Where(a => a.ID == id));
                db.SaveChanges();
            }
            catch { }
           
        }
        public static void DeleteLectures(int id)
        {
            try {db.Lectures.Remove(db.Lectures.SingleOrDefault(a => a.ID == id));
            db.SaveChanges(); }
            catch { }
            
        }
        public static void DeleteAllLectures()
        {
            try {db.Lectures.RemoveRange(db.Lectures); db.SaveChanges(); }
            catch { }
            
        }
        public static void DeleteGroup(int id)
        {
            try {  Group g = db.Groups.SingleOrDefault(a=>a.ID == id);
            DeleteStudentGroups(g.StudentsGroups);
            DeleteAttendances(g.Attendances);
            DeleteExams(g.Exams);
            db.Groups.Remove(g);
            db.SaveChanges();}
            catch { }
           
        }
        public static void DeleteGroups(ICollection<Group> g)
        {
            foreach (Group gr in g) DeleteGroup(gr.ID);  
        }
        public static void DeleteAllGroups()
        {
            try {DeleteAllStudentGroups();
            DeleteAllAttendances();
            DeleteAllExams();
            db.Groups.RemoveRange(db.Groups);
            db.SaveChanges(); }
            catch { }
            
        }
    }
}
