using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    internal interface AttendanceInterFace
    {
        int GroupID { get; set; }
        int LecID { get; set; }
        int StudentNumber { get; set; }
        int StudentCode { get; set; }
        string CurrentLec { get; set; }
        object StudentDataSource { get; set; }
    }
}
