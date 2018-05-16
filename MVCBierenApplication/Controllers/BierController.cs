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
        private BrouwerService brouwerService = new BrouwerService();

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

        public ActionResult Add()
        {
            //var brouwers = brouwerService.FindAll();
            //Dictionary<int, string> BrouwerDic = new Dictionary<int, string>();
            
            //foreach (var brouwer in brouwers)
            //{
            //    BrouwerDic.Add(brouwer.BrouwerNr, brouwer.BrNaam);
            //}

            //ViewData["Brouwers"] = new SelectList(BrouwerDic);

            Bier bier = new Bier()
            {
                
            };
            return View(bier);
        }

        [HttpPost]
        public ActionResult Add(Bier bier)
        {
            if (this.ModelState.IsValid)
            {
                bierService.AddBier(bier);
                TempData["Message"] = bier.Naam + ' ' + "werd toegevoegd";
                return RedirectToAction("Index");
            }
            else
            {
                return View(bier);
            }
           
        }
    }
}