using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    public interface AddStudentInterFace {
        string STName { get; set; }
        int STCode { get; set; }
        bool isMale { get; set; }
        int StClass { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string ParentNumber { get; set; }
        bool IsForContact { get; set; }
        string School { get; set; }
        int Type { get; set; }
        object ClassDataSource { get; set; }
        double discount { get; set; }
        int SelectedClass { get; set; }
    }
}
