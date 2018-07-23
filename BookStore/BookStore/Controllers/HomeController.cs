using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        DepartmentContext db = new DepartmentContext();

        public IEnumerable<Person> GetPersons()
        {
            return db.Persons;
        }

        public ActionResult Index()
        {
            // получаем из бд все объекты Department
            IEnumerable<Department> departments = db.Departments;
            // возвращаем представление
            return View(departments);
        }
    }

}