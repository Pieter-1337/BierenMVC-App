using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCBierenApplication.Models;

namespace MVCBierenApplication.Services
{
    public class BrouwerService
    {

        public List<Brouwer> FindAll()
        {
            using (var db = new MVCBierenEntities())
            {
                var query = db.Brouwers.ToList();
                return query;
            }

        }
    }
}