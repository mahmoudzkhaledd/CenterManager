using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    public interface AddGroupInterFace
    {
        int SelectedClass { get; set; }
        object ClassDataSource { get; set; }
        string GroupName { get; set; }
        DateTime YearStart { get; set; }
        DateTime YearEnd { get; set; }
        int Subject { get; set; }
        object SubjectDataSource { get; set; }
        string FromTime { get; set; }
        string ToTime { get; set; }
        int Class { get; set; }
        bool IsActive { get; set; }
        float Price { get; set; }
        string Note { get; set; }
        bool Sat { get; set; }
        bool Sun { get; set; }
        bool Mon { get; set; }
        bool Tues { get; set; }
        bool Wed { get; set; }
        bool Thurs { get; set; }
        bool Fri { get; set; }
    }
}
