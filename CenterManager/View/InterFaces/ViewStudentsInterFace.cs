using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterManager.View.InterFaces
{
    public interface ViewStudentsInterFace
    {
        object StudentDataSource { set; get; }
        DataGridViewRow SelectedRow { set; get; }
        string Search { set; get; }
    }
}
