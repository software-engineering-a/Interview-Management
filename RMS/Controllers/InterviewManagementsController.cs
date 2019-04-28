using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RMS.Models;

namespace RMS.Controllers
{
    public class InterviewManagementsController : Controller
    {
        private DBConnection db = new DBConnection();

        // GET: InterviewManagements
        public ActionResult Index()
        {
            return View(db.interview_mangement.ToList());
        }

        // GET: InterviewManagements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InterviewManagement interviewManagement = db.interview_mangement.Find(id);
            if (interviewManagement == null)
            {
                return HttpNotFound();
            }
            return View(interviewManagement);
        }

        // GET: InterviewManagements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InterviewManagements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UID,interview_date,time,status")] InterviewManagement interviewManagement)
        {
            if (ModelState.IsValid)
            {
                db.interview_mangement.Add(interviewManagement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(interviewManagement);
        }

        // GET: InterviewManagements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InterviewManagement interviewManagement = db.interview_mangement.Find(id);
            if (interviewManagement == null)
            {
                return HttpNotFound();
            }
            return View(interviewManagement);
        }

        // POST: InterviewManagements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UID,interview_date,time,status")] InterviewManagement interviewManagement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(interviewManagement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(interviewManagement);
        }

        // GET: InterviewManagements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InterviewManagement interviewManagement = db.interview_mangement.Find(id);
            if (interviewManagement == null)
            {
                return HttpNotFound();
            }
            return View(interviewManagement);
        }

        // POST: InterviewManagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InterviewManagement interviewManagement = db.interview_mangement.Find(id);
            db.interview_mangement.Remove(interviewManagement);
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
