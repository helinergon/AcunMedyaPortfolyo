using AcunMedyaPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class DefaultController : Controller
    {


        // GET: Default
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialTestimonial()
        {
            var values=db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var values = db.Tbl_Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            var values = db.Tbl_Contact.ToList();
            return PartialView(values);
        }
        public ActionResult PartialMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult PartialMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.Tbl_Abaut.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.Tbl_Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProject()
        {
            var values = db.Tbl_Project.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {
            var values = db.Tbl_Education.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialJob()
        {
            var values = db.Tbl_Job.ToList();
            return PartialView(values);
        }

    }
}