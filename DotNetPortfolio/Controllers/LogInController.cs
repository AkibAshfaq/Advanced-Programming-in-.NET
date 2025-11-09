using DotNetPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace DotNetPortfolio.Controllers
{
    public class LogInController : Controller
    {
        [HttpPost]
        public ActionResult SignIn()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult LogIn()
        //{
        //    ViewBag.name = Request["Name"];

        //    return View(ViewBag);
        //}



        //Model binding
         //GET: LogIn
        public ActionResult LogIn(LogIn login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }




        //Name Mapping
        //public ActionResult LogIn(string Name)
        //{
        //    ViewBag.name = Name;

        //    return View(ViewBag);
        //}


    }
}