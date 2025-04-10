using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class ProjectController : Controller
    {
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1  ();
        // GET: Project
        public ActionResult Index()
        {
            var values = db.Tbl_Project.ToList();
            return View(values);
        }
        public ActionResult DeleteProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(Tbl_Project project)
        {
            db.Tbl_Project.Add(project);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateProject(Tbl_Project model)
        {
            var value = db.Tbl_Project.Find(model.ProjectID);
            value.ProjectName = model.ProjectName;
            value.Description = model.Description;
            value.ProjectLink = model.ProjectLink;
            value.Image1 = model.Image1;
            value.Image2 = model.Image2;
            value.Image3 = model.Image3;
            value.CategoryID= model.CategoryID;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}