using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();

        // GET: About
        public ActionResult Index()
        {
            var values = db.Tbl_Abaut.ToList();
            return View(values);
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db .Tbl_Abaut.Find(id);
            db.Tbl_Abaut.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(Tbl_Abaut abaut)
        {
            db.Tbl_Abaut.Add(abaut);
            db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}