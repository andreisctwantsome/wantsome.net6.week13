using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationOnFramework.Models;

namespace WebApplicationOnFramework.Controllers
{
    public class HomeController : Controller
    {
        // /Home/Index
        public ActionResult Index()
        {
            // search a view Index in Home folder
            return View();
        }

        // /Home/IndexWithId/2
        public ActionResult IndexWithId(int id)
        {
            return View("Index");
        }

        // /Home/About
        public ActionResult About()
        {
            ViewBag.Message = "About page!!";

            return View();
        }

        // /Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            var manager = new ContactManager();

            var contact = manager.GetDefaultContact();

            var view = View(contact);

            return view;
        }
    }
}