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
        private static Dictionary<int, Bier> bieren = new Dictionary<int, Bier>();

        //Normaal haal je hier gegevens op uit de database hier bootsen we die even na
        static BierService()
        {
            bieren[1] = new Bier { ID = 1, Naam = "Cnudde Kriek", Alcohol = 4.7F };
            bieren[2] = new Bier { ID = 2, Naam = "Liefmans goudenband", Alcohol = 8F };
            bieren[3] = new Bier { ID = 3, Naam = "Sloeber", Alcohol = 7.5F };
            bieren[4] = new Bier { ID = 4, Naam = "Felix kriekbier", Alcohol = 5F };

        }

        public List<Bier> FindAll()
        {
            return bieren.Values.ToList();
        }

        public Bier GetBier(int id)
        {
            Bier bier = bieren.Values.Where(e => e.ID == id).SingleOrDefault();
            return bier;
        }

        public void DeleteBier(int id)
        {
            Bier bier = bieren.Values.Where(e => e.ID == id).SingleOrDefault();
            bieren.Remove(bier.ID);
        }

        public void AddBier(Bier bier)
        {
            bier.ID = bieren.Keys.Max() + 1;
            bieren.Add(bier.ID, bier);
        }
    }
}