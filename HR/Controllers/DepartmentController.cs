using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewDepartment()
        {
            return View();
        }
        [HttpPost]

        public ActionResult NewDepartment(Department ObjDepartment)
        {
            DepartmentDAL ObjDepartmentDAL = new DepartmentDAL();
            ObjDepartmentDAL.InsertDepartment(ObjDepartment);
            return View();
        }
    }
}