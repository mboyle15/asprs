
using asprs3.Models;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;

namespace asprs3.Controllers
{
    public class ActivityController : Controller
    {
        Model1 db = new Model1();

        // GET: Activity
        [Authorize]
        public ActionResult ActivityManager()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddActivity(Activity model)
        {
            try
            {
                db.Activities.Add(model);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    return RedirectToAction("EditActivity", "Activity");
                }
            }
            catch (DbEntityValidationException e)
            {

            }
            return View("Activity Not Added");

        }
        public ActionResult EditTrip()
        {
            return View(db.Activities.ToList());
        }

        public ActionResult DeleteTrip(int id)
        {
            return View(db.Activities.Find(id));
        }


    }
}