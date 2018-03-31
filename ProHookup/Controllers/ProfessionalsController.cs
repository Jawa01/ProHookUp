﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProHookup.Models;

namespace ProHookup.Controllers
{
    public class ProfessionalsController : Controller
    {
        private ProFinderDBEntities2 db = new ProFinderDBEntities2();

        // GET: Professionals
        public ActionResult Index()
        {
            return View(db.Professionals.ToList());
        }

        // GET: Professionals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professional professional = db.Professionals.Find(id);
            if (professional == null)
            {
                return HttpNotFound();
            }
            return View(professional);
        }

        // GET: Professionals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professionals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Proid,FirstName,LastName,Email,Profession,About,Phone,Street,City,StateCode,Zip")] Professional professional)
        {
            if (ModelState.IsValid)
            {
                db.Professionals.Add(professional);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(professional);
        }

        // GET: Professionals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professional professional = db.Professionals.Find(id);
            if (professional == null)
            {
                return HttpNotFound();
            }
            return View(professional);
        }

        // POST: Professionals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Proid,FirstName,LastName,Email,Profession,About,Phone,Street,City,StateCode,Zip")] Professional professional)
        {
            if (ModelState.IsValid)
            {
                db.Entry(professional).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(professional);
        }

        // GET: Professionals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professional professional = db.Professionals.Find(id);
            if (professional == null)
            {
                return HttpNotFound();
            }
            return View(professional);
        }

        // POST: Professionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Professional professional = db.Professionals.Find(id);
            db.Professionals.Remove(professional);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
