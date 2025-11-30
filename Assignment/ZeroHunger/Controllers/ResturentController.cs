using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Models;
using ZeroHunger.EF;

namespace ZeroHunger.Controllers
{
    public class ResturentController : Controller
    {
        ZeroHungerNGOEntities db = new ZeroHungerNGOEntities();

        [HttpGet]
        public ActionResult DashBoard()
        {
            var requests = db.Requests.ToList();

            return View(requests);
        }

        [HttpPost]
        public ActionResult DashBoard(ResturentRequests resturent)
        {
            // Map ResturentRequests to Request
            var request = new Request
            {
                ResturentName = resturent.ResturentName,
                ResturentLocation = resturent.ResturentLocation,
                PreserveDate = resturent.PreserveDate,
                Assigned = resturent.Assigned,
                Status = resturent.Status
            };

            db.Requests.Add(request);
            db.SaveChanges();

            var requests = db.Requests.ToList();

            return View(requests);
        }

        
    }
}