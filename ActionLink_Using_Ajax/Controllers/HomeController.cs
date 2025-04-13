using ActionLink_Using_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionLink_Using_Ajax.Controllers
{
    public class HomeController : Controller
    {
        DemoEntities db = new DemoEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employee()
        {
            return PartialView("_EmployeeDetails",db.Employees.ToList());
        }
        public ActionResult TopTwo()
        {
            return PartialView("_EmployeeDetails",db.Employees.OrderByDescending(model => model.salary).Take(2).ToList());
        }
        public ActionResult LowestTwo()
        {
            return PartialView("_EmployeeDetails", db.Employees.OrderBy(model => model.salary).Take(2).ToList());
        }

        
    }
}