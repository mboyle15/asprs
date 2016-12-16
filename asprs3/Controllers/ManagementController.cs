using asprs3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asprs3.Controllers
{
    public class ManagementController : Controller
    {
        Model1 db = new Model1();
        public ManagementController()
        {
            db = new Model1();
        }


        public ActionResult ViewActivities()
        {
            var ActivityList = from a in db.Activities
                               select a;

            return View(ActivityList.ToList());
        }


        public ActionResult AddActivity()
        {
            //Send to the view, the userTypeList
            IEnumerable<SelectListItem> ActivityID = new SelectList(db.Activities.ToList(), "ActivityID");
            ViewData["ActivityID"] = ActivityID;

            return View();
        }

        [HttpPost]
        public ActionResult AddActivity(Activity model)
        {
            try
            {
                db.Activities.Add(model);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    return RedirectToAction("ViewActivities", "Management");
                }
            }
            catch (DbEntityValidationException e)
            {

            }
            return View("Trip Not Added");
        }

        public ActionResult EditActivity(int id)
        {
            //Send to the view, the userTypeList
            IEnumerable<SelectListItem> ActivityID = new SelectList(db.Activities.ToList(), "Activity_ID");
            ViewData["ActivityID"] = ActivityID;

            return View(db.Activities.Find(id));
        }

        [HttpPost]
        public ActionResult EditActivity(Activity a)
        {
            var update = db.Activities.Find(a.ActivityID);
            update.ActivityFacilitator = a.ActivityFacilitator;
            update.ActivityLocation = a.ActivityLocation;
            update.ActivityStartTime = a.ActivityStartTime;
            update.ActivityEndTime = a.ActivityEndTime;
            update.DailyCost = a.DailyCost;
            update.Cost = a.Cost;
            update.Capacity = a.Capacity;
            update.CurrentEnrollment = a.CurrentEnrollment;
            update.EligibleGrades = a.EligibleGrades;
            update.OfferedDays = a.OfferedDays;
            update.Quarter = a.Quarter;

            db.SaveChanges();

            return RedirectToAction("ViewActivities", "Management");
        }

        public ActionResult DeleteActivity(int id)
        {
            return View(db.Activities.Find(id));
        }


        [HttpPost]
        public ActionResult DeleteActivity(int id)
        {
            Activity delete = db.Activities.Find(id);
            if (delete == null)
            {
                return RedirectToAction("ViewActivities", "Management");
            }
            db.Activities.Remove(delete);
            db.SaveChanges();

            return RedirectToAction("ViewActivities", "Management");
        }

    }
}