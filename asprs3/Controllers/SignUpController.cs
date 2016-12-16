using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using asprs3.Models;
using System.Web.WebPages;
using asprs3.Models;


namespace asprs3.Controllers
{
    public class SignUpController : Controller
    {

        Model1 db = new Model1();
        public SignUpController()
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
                                    m.StudentFName == FName 
                                    && m.StudentLName == LName 
                                    && DOB.Equals(m.StudentDOB)
                                  select m;

            return View(existingStudent.ToList());
        }


    }
}