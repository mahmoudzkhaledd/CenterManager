using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    internal interface EditSubjectInterFace
    {
        object ClassesDataSource { set; get; }
        string Class_Name { set; get; }
        int id { set; get; }
        string Search { set; get; }
    }
}
