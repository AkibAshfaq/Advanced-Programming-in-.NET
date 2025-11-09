using Lab03_Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03_Student.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            var s = new Student();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}