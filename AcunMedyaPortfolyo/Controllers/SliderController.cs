using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class SliderController : Controller
    {
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        // GET: Slider
        public ActionResult Index()
        {
            var values = db.Tbl_Slider.ToList();

            return View(values);
        }
        public ActionResult DeleteSlider(int id)
        {
            var values = db.Tbl_Slider.Find(id);
            db.Tbl_Slider.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSlider(Tbl_Slider slider)
        {
            db.Tbl_Slider.Add(slider);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}