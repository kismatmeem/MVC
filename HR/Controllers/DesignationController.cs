using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class DesignationController : Controller
    {
        // GET: Designation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewDesignation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewDesignation(Designation ObjDesignation)
        {
            DesignationDAL ObjDesignationDAL = new DesignationDAL();
            ObjDesignationDAL.InsertDesignation(ObjDesignation);
            return View();
        }
    }
}