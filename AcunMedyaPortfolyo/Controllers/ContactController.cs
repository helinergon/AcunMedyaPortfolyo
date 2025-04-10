﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DbAcunMedyaProject1Entities1 db = new DbAcunMedyaProject1Entities1();
        public ActionResult Index()
        {
            var values = db.Tbl_Contact.ToList();
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var values = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(Tbl_Contact contact)
        {
            db.Tbl_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = db.Tbl_Contact.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateContact(Tbl_Contact model)
        {
            var value = db.Tbl_Contact.Find(model.ContactID);
            value.Description = model.Description;
            value.Adress = model.Adress;
            value.Email= model.Email;
            value.Phone = model.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}