﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class MessageController : Controller
    {
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();
        // GET: Message
        public ActionResult Index()
        {
            var values = db.Tbl_Message.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var values = db.Tbl_Message.Find(id);
            db.Tbl_Message.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMessage(Tbl_Message message)
        {
            db.Tbl_Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var values = db.Tbl_Message.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateMessage(Tbl_Message model)
        {
            var value = db.Tbl_Message.Find(model.MessageID);
            value.NameSurname = model.NameSurname;
            value.Mail = model.Mail;
            value.Subject = model.Subject;
            value.MessageContent = model.MessageContent;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}