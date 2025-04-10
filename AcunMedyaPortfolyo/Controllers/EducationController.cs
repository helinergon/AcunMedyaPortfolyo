using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class EducationController : Controller
    {
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();
        // GET: Education
        public ActionResult Index()
        {
            var values = db.Tbl_Education.ToList();
            return View(values);
        }
        public ActionResult DeleteEducation(int id)
        {
            var values = db.Tbl_Education.Find(id);
            db.Tbl_Education.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(Tbl_Education education)
        {
            db.Tbl_Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var values = db.Tbl_Education.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateEducation(Tbl_Education model)
        {
            var value = db.Tbl_Education.Find(model.EducationID);
            value.StartYear = model.StartYear;
            value.EndYear = model.EndYear;
            value.Name = model.Name;
            value.Description = model.Description;
            value.Section = model.Section;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}