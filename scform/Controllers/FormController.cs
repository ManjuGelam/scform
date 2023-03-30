using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scform.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            ViewBag.UserTypeList = new List<SelectListItem>
            {
             
            new SelectListItem { Text = "User", Value = "User" },
            new SelectListItem { Text = "Admin", Value = "Admin" },
        };
            return View();
        }
    }
}