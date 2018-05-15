using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult Verwijder(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bier bier = bierService.GetBier((int)id);

            return View(bier);
        }

        [HttpPost]
        public ActionResult Verwijder(int id)
        {
            bierService.DeleteBier(id);
            TempData["Message"] = "Het bier werd succesvol verwijderd";

            return RedirectToAction("Index");
        }
    }
}