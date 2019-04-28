using RMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RMS.Controllers
{
    public class HRMInterviewController : Controller
    {
        private DBConnection db = new DBConnection();

        // GET: HRMInterview
        public ActionResult Index()
        {
            return View(db.interview_mangement.ToList());
        }
        public ActionResult AddMarks(int? id)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMarks(int? id,int marks)
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
            interviewManagement.marks = marks;

            db.Entry(interviewManagement).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }


    }
}