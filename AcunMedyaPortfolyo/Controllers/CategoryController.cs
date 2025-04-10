using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();
        public ActionResult Index()
        {
            var values = db.Tbl_Category.ToList();
            return View(values);
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.Tbl_Category.Find(id);
            db.Tbl_Category.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Tbl_Category category)
        {
            db.Tbl_Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.Tbl_Category.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateCategory(Tbl_Category model)
        {
            var value = db.Tbl_Category.Find(model.CategoryID);
            value.CategoryName=model.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}