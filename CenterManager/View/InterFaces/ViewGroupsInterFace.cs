using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    public interface ViewGroupsInterFace
    {
        object GroupsDataSours { get; set; }
        int id { get; set; }
        string Search { get; set; }
    }
}
