using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace S1P01_u24660932.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult ListStudents()
        {
            List<Models.Class1> students = new List<Models.Class1>();

            students.Add(new Models.Class1{StudentNumber = "u24660932", Name = "Ntsako", Surname = "Sibasa", EmailAddress = "u24660932@tuks.co.za" });
            students.Add(new Models.Class1{StudentNumber = "u23587874", Name = "Lizalise", Surname = "Mbonisweni", EmailAddress = "u23587874@tuks.co.za" });
            students.Add(new Models.Class1{StudentNumber = "u24840859", Name = "Nelisile", Surname = "Nobela", EmailAddress = "u24840859@tuks.co.za" });
            students.Add(new Models.Class1{StudentNumber = "u24713407", Name = "Tiyana", Surname = "Vanmali", EmailAddress = "u24713407@tuks.co.za" });
            students.Add(new Models.Class1{StudentNumber = "u23547937", Name = "Rolivhuwa", Surname = "Mphaphuli", EmailAddress = "u23547937@tuks.co.za" });

            return View(students);
        }
    }
}