using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.View.InterFaces
{
    internal interface ViewBooksInterFace
    {
        int id { get; set; }
        string Search { get; set; }
        object BooksDataSource { get; set; }
    }
}
