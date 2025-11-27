using PortfoliowithDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfoliowithDB.EF;

namespace PortfoliowithDB.Controllers
{
    public class PortfolioController : Controller
    {

        InformationEntities db = new InformationEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View(new login());
        }

        [HttpPost]
        public ActionResult Index(login l)
        {

            db.Infos.Add(new Info()
            {
                Name = l.Name,
                Email = l.Email,
                Address = l.Address
            });
            db.SaveChanges();

            if (ModelState.IsValid)
            {
                return RedirectToAction("dashboard");
            }

            return View(new login());
        }


        public ActionResult dashboard()
        {

            var data = db.Infos.ToList();

            return View(data);

        }

        public ActionResult delete(int id)
        {
            var data = db.Infos.Find(id);
            db.Infos.Remove(data);
            db.SaveChanges();

            var updatedData = db.Infos.ToList();

            return RedirectToAction("dashboard", updatedData);
        }

        [HttpGet]
        public ActionResult edit(int id)
        {
            var data = db.Infos.Find(id);


            return View(data);
        }

        [HttpPost]
        public ActionResult edit(Info info)
        {
            var data = db.Infos.Find(info.id);
            data.Name = info.Name;
            data.Email = info.Email;
            data.Address = info.Address;
            db.SaveChanges();
            return RedirectToAction("dashboard");
        }
    }
}