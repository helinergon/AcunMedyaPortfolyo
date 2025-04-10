using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class ServicesController : Controller
    {
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1  ();
        // GET: Services
        public ActionResult Index()
        {
            var values = db.Tbl_Services.ToList();
            return View(values);
        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.Tbl_Services.Find(id);
            db.Tbl_Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateServices(Tbl_Services services)
        {
            db.Tbl_Services.Add(services);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = db.Tbl_Services.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateServices(Tbl_Services model)
        {
            var value = db.Tbl_Services.Find(model.ServicesID);
            value.Description = model.Description;
            value.Title = model.Title;
            value.IconUrl = model.IconUrl;
            value.Description2 = model.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}