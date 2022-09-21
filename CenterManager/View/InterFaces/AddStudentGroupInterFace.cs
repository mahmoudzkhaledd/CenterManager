using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    internal interface AddStudentGroupInterFace
    {
        string ClassName { get; set; }
        int ClassID { get; set; }
        string Search { get; set; }
        int GroupID { get; set; }
        int STID { get; set; }
        int StudentNumber { get; set; }
        object StudentDataSource { get; set; }
        object GroupsDataSource { get; set; }
    }
}
