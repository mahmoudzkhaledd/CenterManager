using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    internal interface ViewAttendanceInterFace
    {
        object StudentsDataSource { get; set; }
        object LecDataSource { get; set; }
        object GroupsDataSource { get; set; }
        string Search { get; set; }

        int GroupID { get; }
        int LecID { get; set; }
    }
}
