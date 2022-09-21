using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    internal interface StudentBookInterFace
    {
        object BooksDataSource { get; set; }
        object StudentsDataSource { get; set; }
        int SelectedBookID { get; set; }
        string SubjectName { get; set; }
        string ClassName { get; set; }
        int Number { get; set; }
        int ClassID { get; set; }
        int SubjectID { get; set; }
    }
}
