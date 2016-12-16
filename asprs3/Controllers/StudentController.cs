using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using asprs3.Models;
using System.Web.WebPages;
using asprs3.Models;


namespace asprs3.Controllers
{
    public class StudentController : Controller
    {
        Model1 db = new Model1();
        // GET: Students
        public StudentController()
        {
            db = new Model1();
        }
            
        
        public ActionResult SelectStudent()
        {
            return View();
        }
        
        
        [HttpPost]
        public ActionResult ViewStudent(Student viewModel)
        //Get entered Student information and query it against Students, if student exists in Students, add Guardianship entity
        {
            var FName = viewModel.StudentFName;
            var LName = viewModel.StudentLName;
            var DOB = viewModel.StudentDOB;

            var existingStudent = from m in db.Students
                                  where 
                                    m.StudentFName == FName &&
                                    m.StudentLName == LName &&
                                    DOB.Equals(m.StudentDOB)
                                  select m;

            return View(existingStudent.ToList());
        }


        



        /*
        [Authorize(Roles = "Parent")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteStudent()
        {
            string userId = User.Identity.GetUserId();
            int id = Request.Form["studentId"].AsInt();

            ViewBag.Stud_F_Name = db.Students.Find(id).Stud_F_Name;
            ViewBag.Stud_L_Name = db.Students.Find(id).Stud_L_Name;
            ViewBag.Date_Of_Birth = db.Students.Find(id).Date_Of_Birth.ToShortDateString();

            var guardianshipId = from m in db.Guardianships
                                 where m.UserName == userId && m.Student_Number == id
                                 select m;

            if (guardianshipId.Count() > 1)
            {
                return RedirectToAction("DeleteStudent", "Students");
            }
            var output = guardianshipId.First();

            return View(output);
        }
        [Authorize(Roles = "Parent")]
        public ActionResult ConfirmDeleteStudent(int id)
        {
            //Deletes relation between parent & student
            Guardianship delete = db.Guardianships.Find(id);
            if (delete == null)
            {
                return RedirectToAction("ManageStudent", "Students");
            }
            db.Guardianships.Remove(delete);
            db.SaveChanges();

            return RedirectToAction("ManageStudent", "Students");
        }
        [Authorize(Roles = "Parent")]
        public ActionResult AddGuardianship()
        {

            return View();
        }
        */
    }
}
