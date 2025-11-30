using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.EF;
using Practice.Models;


namespace Practice.Controllers
{
    public class DataController : Controller
    {

        TestEntities db = new TestEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Data Index Page.";                               // No need to put parameter in View() method
            ViewData["CurrentTime"] = DateTime.Now.ToString("F");               // No need to put parameter in View() method
            TempData["Notice"] = "This is a temporary notice message.";         // No need to put parameter in View() method

            return View();
        }

        [HttpGet]
        public ActionResult Formprocess()
        { 
            var data = db.FormDetails.ToList();

            return View(data);
        }

        [HttpPost]
        
        public ActionResult Formprocess(FormCollection fc) //Action with Form Collection method Form processing
        {
            db.FormDetails.Add(new FormDetail
            {
                FormName = fc["FormName"],
                Name = fc["Name"],
                Number = Convert.ToInt32( fc["Number"])
            }
            );
            db.SaveChanges();

            return RedirectToAction("Formprocess");
        }

        [HttpPost]
        public ActionResult Vmap(string Name, string Number, string Formname) // Action with Variable mapping method Form processing
        {
            db.FormDetails.Add(new FormDetail
            {
                FormName = Formname,
                Name = Name,
                Number = Convert.ToInt32(Number)
            }
            );
            db.SaveChanges();

            return RedirectToAction("Formprocess");
        }

        [HttpPost]
        public ActionResult MBinding(FormModel model) // Action with Model Binding method Form processing
        {
            db.FormDetails.Add(new FormDetail
            {
                FormName = model.Formname,
                Name = model.Name,
                Number = Convert.ToInt32(model.Number)
            }
            );
            db.SaveChanges();

            return RedirectToAction("Formprocess");
        }


        [HttpPost]
        public ActionResult hrequest()              // Action with HttpRequest method Form processing
        {
            db.FormDetails.Add(new FormDetail
            {
                FormName = Request["FormName"],
                Name = Request["Name"],
                Number = Convert.ToInt32(Request["Number"])
            }
            );
            db.SaveChanges();

            return RedirectToAction("Formprocess");
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var person = db.FormDetails.Find(id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(FormModel model,int id)
        {
            var person = db.FormDetails.Find(id);
            person.FormName = model.Formname;
            person.Name = model.Name;
            person.Number = Convert.ToInt32(model.Number);
            db.SaveChanges();
            return RedirectToAction("Formprocess");
        }

        public ActionResult Delete(int id)
        {
            var person = db.FormDetails.Find(id);
            db.FormDetails.Remove(person);
            db.SaveChanges();

            return RedirectToAction("Formprocess");
        }


        [HttpGet]
        public ActionResult lnq()
        {
            var data = db.FormDetails.ToList();

            return View(data);
        }


        [HttpPost]
        public ActionResult lnq(string type)
        {
            var data = from d in db.FormDetails
                       where d.FormName == type
                       select d;
            return View(data.ToList());
        }



    }
}