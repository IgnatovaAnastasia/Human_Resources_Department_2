using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class AllPersonController : Controller
    {
        DepartmentContext db = new DepartmentContext();
        [HttpGet]
        public ActionResult AllPerson(int id)
        {
            return View(db.Persons.Where(pers => pers.DepartmentId == id));
        }
    }
}