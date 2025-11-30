using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.EF;

namespace ZeroHunger.Controllers
{
    public class PortalController : Controller
    {
        ZeroHungerNGOEntities db = new ZeroHungerNGOEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AssignStatus(int id)
        {
            var assign = db.Requests.Find(id);
            assign.Status = "Assigned";

            return View();
        }

        public ActionResult CompleteStatus(int id)
        {
            var assign = db.Requests.Find(id);
            assign.Status = "Completed";

            return View();
        }
    }
}