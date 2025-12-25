using HR.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class EmployeeController : Controller
    {
        //// GET: Employee
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Index()
        {
            // Session check
            if (Session["username"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }

        public ActionResult NewEmployee()
        {
            return View();
        }
        [HttpPost]

        public ActionResult NewEmployee(Employee ObjEmployee)
        {
            EmployeeDAL ObjEmployeeDAL = new EmployeeDAL();
            ObjEmployeeDAL.InsertEmployee(ObjEmployee);
            return View();
        }
    }
}