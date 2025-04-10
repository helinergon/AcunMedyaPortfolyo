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
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();

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
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.Tbl_Abaut.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateAbout(Tbl_Abaut model)
        {
            var value = db.Tbl_Abaut.Find(model.AbautID);
            value.ImageURL = model.ImageURL;
            value.Title = model.Title;
            value.BirthDay = model.BirthDay;
            value.WebSite = model.WebSite;
            value.Phone = model.Phone;
            value.City = model.City;
            value.Age = model.Age;
            value.Email = model.Email;
            value.FreeLance = model.FreeLance;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.Degree = model.Degree;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}