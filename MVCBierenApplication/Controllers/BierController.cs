using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBierenApplication.Models;
using MVCBierenApplication.Services;

namespace MVCBierenApplication.Controllers
{
    public class BierController : Controller
    {
        private BierService bierService = new BierService();

        // GET: Bier
        public ActionResult Index()
        {
            var bieren = bierService.FindAll();
            return View(bieren);
        }
    }
}