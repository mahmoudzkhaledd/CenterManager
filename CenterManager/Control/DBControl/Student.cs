//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CenterManager.Control.DBControl
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Attendances = new HashSet<Attendance>();
            this.StudentBooks = new HashSet<StudentBook>();
            this.StudentExams = new HashSet<StudentExam>();
            this.StudentsGroups = new HashSet<StudentsGroup>();
        }
    
        public int ID { get; set; }
        public int STCode { get; set; }
        public string Name { get; set; }
        public string ST_Phone { get; set; }
        public string Address { get; set; }
        public string Parent_Number { get; set; }
        public bool Is_for_Contact { get; set; }
        public bool IsMale { get; set; }
        public Nullable<int> ClassID { get; set; }
        public string School { get; set; }
        public byte Study_Level { get; set; }
        public double Discount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Class Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentBook> StudentBooks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentExam> StudentExams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGroup> StudentsGroups { get; set; }
    }
}
