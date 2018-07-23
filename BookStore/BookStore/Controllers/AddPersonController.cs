using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class AddPersonController : Controller
    {
        DepartmentContext db = new DepartmentContext();
        [HttpGet]
        public ActionResult AddPerson(int id)
        {
            //<input type="hidden" value="@ViewBag.PersonId" name="PersonId" />
            ViewBag.DepartmentId = id;
            return View();
        }
        [HttpPost]
        public string Save(Person somebody)
        {
            //IEnumerable<Person> persons = db.Persons;
            db.Persons.Add(somebody);
            db.SaveChanges();
            return somebody.Name + " " + somebody.LastName + " added to db sucassefully";
        }
    }
}