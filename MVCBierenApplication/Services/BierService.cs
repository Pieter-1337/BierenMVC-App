using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBierenApplication.Models;
using System.Data;

namespace MVCBierenApplication.Services
{
    public class BierService
    {
        //private static Dictionary<int, Bier> bieren = new Dictionary<int, Bier>();

        //Normaal haal je hier gegevens op uit de database hier bootsen we die even na
        //static BierService()
        //{
        //    bieren[1] = new Bier { ID = 1, Naam = "Cnudde Kriek", Alcohol = 4.7F };
        //    bieren[2] = new Bier { ID = 2, Naam = "Liefmans goudenband", Alcohol = 8F };
        //    bieren[3] = new Bier { ID = 3, Naam = "Sloeber", Alcohol = 7.5F };
        //    bieren[4] = new Bier { ID = 4, Naam = "Felix kriekbier", Alcohol = 5F };

        //}

        

        public List<Bier> FindAll()
        {
            using(var db = new MVCBierenEntities())
            {
                return db.Biers.ToList();
            }
            
        }

        public Bier GetBier(int id)
        {
            using(var db = new MVCBierenEntities())
            {
                return db.Biers.Find(id);
            }
        }

        public void DeleteBier(int id)
        {
            using(var db = new MVCBierenEntities())
            {
                Bier bier = new Bier();
                bier = db.Biers.Find(id);
                db.Biers.Remove(bier);
                db.SaveChanges();
            }
        }

        public void AddBier(Bier bier)
        {
           using(var db = new MVCBierenEntities())
            {
                db.Biers.Add(bier);
                db.SaveChanges();
            }
        }
    }
}