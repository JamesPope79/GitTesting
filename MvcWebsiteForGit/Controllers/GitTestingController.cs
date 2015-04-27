using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcWebsiteForGit.Models;

namespace MvcWebsiteForGit.Controllers
{
    public class GitTestingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GitTesting
        public ActionResult Index()
        {
            return View(db.GitTestings.ToList());
        }

        // GET: GitTesting/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GitTesting gitTesting = db.GitTestings.Find(id);
            if (gitTesting == null)
            {
                return HttpNotFound();
            }
            return View(gitTesting);
        }

        // GET: GitTesting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GitTesting/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,GitName,GitAge")] GitTesting gitTesting)
        {
            if (ModelState.IsValid)
            {
                db.GitTestings.Add(gitTesting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gitTesting);
        }

        // GET: GitTesting/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GitTesting gitTesting = db.GitTestings.Find(id);
            if (gitTesting == null)
            {
                return HttpNotFound();
            }
            return View(gitTesting);
        }

        // POST: GitTesting/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,GitName,GitAge")] GitTesting gitTesting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gitTesting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gitTesting);
        }

        // GET: GitTesting/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GitTesting gitTesting = db.GitTestings.Find(id);
            if (gitTesting == null)
            {
                return HttpNotFound();
            }
            return View(gitTesting);
        }

        // POST: GitTesting/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GitTesting gitTesting = db.GitTestings.Find(id);
            db.GitTestings.Remove(gitTesting);
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
