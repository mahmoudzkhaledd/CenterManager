using CenterManager.Control.DBControl;
using CenterManager.Control.Methods;
using CenterManager.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterManager.Control.Presenters
{
    public class ViewGroupsPresenter
    {
        ViewGroupsInterFace interFace;
        CenterManagerEntities db = Methods.Methods.db;
        public ViewGroupsPresenter(ViewGroupsInterFace i)
        {
            interFace = i;
            LoadData();
        }
        public void LoadData()
        {
            /* interFace.GroupsDataSours = db.Groups.Join(db.Classes, g => g.ClassID, c => c.ID,
                (g,c)=> new
                 {
                    ID = g.ID,
                    Name = g.Name,
                    StartDate = g.StartDate,
                    EndDate = g.EndDate,
                    ClassID = c.Class_Name,
                    FromHour = g.FromHour,
                    ToHour = g.ToHour,
                    Price = g.Price,
                    IsActive = g.IsActive ? "✔" : "✖",
                    Saturday = g.Saturday ? "✔" : "✖",
                    Sunday = g.Sunday ? "✔" : "✖",
                    Monday = g.Monday ? "✔" : "✖",
                    Tuesday = g.Tuesday ? "✔" : "✖",
                    Wednesday = g.Wednesday ? "✔" : "✖",
                    Thursday = g.Thursday ? "✔" : "✖",
                    Friday = g.Friday ? "✔" : "✖",
                    Note = g.Note,
                }
                 ).ToList();*/
            interFace.GroupsDataSours = db.Groups.Select(x => 
            new { 
                ID = x.ID,
                Name = x.Name,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                ClassID = x.Class.Class_Name,
                FromHour = x.FromHour,
                ToHour = x.ToHour,
                Price = x.Price,
                Subject_ID = x.Subject.Name,
                IsActive = x.IsActive ? "✔" : "✖",
                Saturday = x.Saturday ? "✔" : "✖",
                Sunday = x.Sunday ? "✔" : "✖",
                Monday = x.Monday ? "✔" : "✖",
                Tuesday = x.Tuesday ? "✔" : "✖",
                Wednesday = x.Wednesday ? "✔" : "✖",
                Thursday = x.Thursday ? "✔" : "✖",
                Friday = x.Friday ? "✔" : "✖",
                Note = x.Note,
            }).ToList();
        }

        public void Delete(int id)
        {
            try
            {
                CenterManagerEntities db = Methods.Methods.db;
                db.Groups.Remove(db.Groups.SingleOrDefault(x => x.ID == id));
                db.SaveChanges();
                
            }
            catch { }
        }

        public void DeleteAll()
        {
            DeleteMethods.DeleteAllGroups();
        }

        internal void Search() {
            interFace.GroupsDataSours = db.Groups.Where(x=>x.Name.Contains(interFace.Search)).ToList();
        }
    }
}
