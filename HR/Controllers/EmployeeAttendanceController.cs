using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class EmployeeAttendanceController : Controller
    {
        // GET: EmployeeAttendance
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewEmployeeAttendance()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewEmployeeAttendance(EmployeeAttendance ObjEmployeeAttendance)
        {
            EmployeeAttendanceDAL ObjEmployeeAttendanceDAL = new EmployeeAttendanceDAL();
            ObjEmployeeAttendanceDAL.InsertEmployeeAttendance(ObjEmployeeAttendance);
            return View();
        }
    }
}