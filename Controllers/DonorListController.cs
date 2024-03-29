﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationFinal.Models;

namespace MvcApplicationFinal.Controllers
{
    public class DonorListController : Controller
    {
        private DonorDBContext db = new DonorDBContext();

        //
        // GET: /DonorList/

        public ActionResult Index()
        {
            return View(db.Donors.ToList());
        }

        //
        // GET: /DonorList/Details/5

        public ActionResult Details(int id = 0)
        {
            Person person = db.Donors.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // GET: /DonorList/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DonorList/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Donors.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        //
        // GET: /DonorList/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Person person = db.Donors.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // POST: /DonorList/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        //
        // GET: /DonorList/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Person person = db.Donors.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        //
        // POST: /DonorList/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.Donors.Find(id);
            db.Donors.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}