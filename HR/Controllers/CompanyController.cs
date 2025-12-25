using System.Web.Mvc;
using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class CompanyController : Controller
    {
        //// GET: Company
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
        public ActionResult NewCompany()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCompany(Company ObjCompany)
        {
            CompanyDAL ObjCompanyDAL = new CompanyDAL();
            ObjCompanyDAL.InsertCompany(ObjCompany);
            return View();
        }
    }
}