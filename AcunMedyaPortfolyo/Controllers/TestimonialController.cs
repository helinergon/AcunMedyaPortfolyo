using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class TestimonialController : Controller
    {
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1  ();
        // GET: Testimonial
        public ActionResult Index()
        {
            var values = db.Tbl_Testimonial.ToList();
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Tbl_Testimonial testimonial)
        {
            db.Tbl_Testimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("index");
        }


        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Tbl_Testimonial model)
        {
            var value = db.Tbl_Testimonial.Find(model.TestimonialID);
            value.TestimonialName = model.TestimonialName;
            value.Descripion1 = model.Descripion1;
            value.ImageUrl=model.ImageUrl;
            value.Title = model.Title;
            value.Description2 = model.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}