using FormValidationTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormValidationTask.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        // GET: Index
        [HttpPost]
        public ActionResult LogIn(LogIn login)
        {
            if (ModelState.IsValid)
            {
                ViewBag.message = "Successful submittion";
                return View(ViewBag);
            }
            return View();
        }
    }
}