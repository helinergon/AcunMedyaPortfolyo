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
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
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
    }
}