using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.View;
using CenterManager.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.Control.Presenters
{
    internal class ViewBooksPresenter
    {
        ViewBooksInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        
        public ViewBooksPresenter(ViewBooksInterFace i)
        {
            interFace = i;
            UpdateBooks();
        }

        public void UpdateBooks()
        {
            interFace.BooksDataSource = db.Books.Select(x=>
            new {
                ID = x.ID,
                Name = x.Name,
                Class = x.Class1.Class_Name,
                Price_for_St = x.Price_for_St,
                Price = x.Price,
                Total = x.Total,
                Subject = x.Subject.Name,
                Quantity = x.Quantity,
                Note = x.Note
            }
            ).ToList();
        }

        public  void Delete(int id)
        { 
            CenterManagerEntities db = Methods.Methods.db;
            Book b = db.Books.SingleOrDefault(x => x.ID == id);
            for (int i = 0; i < b.StudentBooks.Count; i++) {
                
            }
            db.Books.Remove(b);
            db.SaveChanges();
            
        }

        public void DeleteAll()
        {
            DeleteMethods.DeleteAllBooks();
        }

        internal void Search()
        {
           // interFace.BooksDataSource = db.Books.Where().Tolist();
        }
    }
}
