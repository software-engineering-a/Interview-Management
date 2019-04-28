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
    public class ApplicantInterviewController : Controller
    {
        private DBConnection db = new DBConnection();

        // GET: HRMInterview
        public ActionResult Index()
        {
            return View(db.interview_mangement.ToList());
        }
        public ActionResult update_status(int? id,string status)
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
            interviewManagement.status = status;

            db.Entry(interviewManagement).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}