using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class JobController : Controller
    {
        DbAcunMedyaProject1Entities db = new DbAcunMedyaProject1Entities();
        // GET: Job
        public ActionResult Index()
        {
            var values = db.Tbl_Job.ToList();
            return View(values);
        }
        public ActionResult DeleteJob(int id)
        {
            var values = db.Tbl_Job.Find(id);
            db.Tbl_Job.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateJob()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateJob(Tbl_Job job)
        {
            db.Tbl_Job.Add(job);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
