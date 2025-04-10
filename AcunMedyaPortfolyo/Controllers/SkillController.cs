using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class SkillController : Controller
    {
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1  ();
        // GET: Skill
        public ActionResult Index()
        {
            var values = db.Tbl_Skill.ToList();
            return View(values);
        }
        public ActionResult DeleteSkill(int id)
        {
            var values = db.Tbl_Skill.Find(id);
            db.Tbl_Skill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(Tbl_Skill skill)
        {
            db.Tbl_Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var values = db.Tbl_Skill.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateSkill(Tbl_Skill model)
        {
            var value = db.Tbl_Skill.Find(model.SkillID);
            value.SkillName = model.SkillName;
            value.Derece = model.Derece;
            value.Description = model.Description;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}