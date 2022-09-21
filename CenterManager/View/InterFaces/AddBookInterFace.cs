using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    internal interface AddBookInterFace
    {
        string BookName { get; set; }
        float PriceForST { get; set; }
        float Price { get; set; }
        float Earnings { get; set; }
        int ClassID { get; set; }
        int SubjectID { get; set; }
        int Quantity { get; set; }
        string Note { get; set; }
        int SelectedClassID { get; set; }
        object ClassDataSource { get; set; }
        object SubjectDataSource { get; set; }

    }
}
