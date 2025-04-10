using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class StatisticsController : Controller
    {
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1 ();
        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.Tbl_Category.Count();
            ViewBag.ProjectCount = db.Tbl_Project.Count();
            ViewBag.ContactCount = db.Tbl_Contact.Count();
            ViewBag.TestimonialCount = db.Tbl_Testimonial.Count();
            return View();
        }
    }
}