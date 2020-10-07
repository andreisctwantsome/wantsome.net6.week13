using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationOnFramework.Models;

namespace WebApplicationOnFramework.Controllers
{
    public class StudentController : Controller
    {
        StudentManager manager;

        public StudentController()
        {
            manager = new StudentManager();
        }

        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {

            List<Student> students = manager.GetAll();

            return View(students);
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            var student = manager.GetById(id);

            return View(student);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                manager.Add(student);

                return RedirectToAction("Index");
            }

            return View(student);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var student = manager.GetById(id);

            return View(student);
        }
    }
}