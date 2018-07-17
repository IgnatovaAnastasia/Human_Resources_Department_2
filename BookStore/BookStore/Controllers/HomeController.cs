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

        public ActionResult Index()
        {
            // получаем из бд все объекты Department
            IEnumerable<Department> departments = db.Departments;
            // передаем все объекты в динамическое свойство Department в ViewBag
            ViewBag.Departments = departments;
            // возвращаем представление
            return View();
        }
        [HttpGet]
        public ActionResult Save(int id)
        {
            ViewBag.DepartmentId = id;
            return View();
        }
        [HttpPost]
        public string Save(Person somebody)
        {
            //somebody.Date = DateTime.Now;
            // добавляем информацию о person в базу данных
            /*if (somebody.Name == "" || somebody.LastName == "" || somebody.Date.IsNull)
                return "Not all fields are filled in";
            else*/
            {
                somebody.PersonId = 88;
                //somebody.BirthDate = DateTime.Today;
                db.Persons.Add(somebody);
                // сохраняем в бд все изменения
                db.SaveChanges();
                return somebody.Name + " " + somebody.LastName + " added to db sucassefully";
            }
        }
        //New_Dep
        [HttpGet]
        public ActionResult New_Dep()
        {
            return View();
        }
        [HttpPost]
        public string New_Dep(Department newD)
        {
            /*if (new_d.Name == "")
                return "Not all fields are filled in";
            else*/

               db.Departments.Add(newD);
                // сохраняем в бд все изменения
                db.SaveChanges();
                return newD.Name + " added to db sucassefully";
        }
        
        [HttpGet]
        public ActionResult All_person(int id)
        {
            IEnumerable<Person> persons = db.Persons.Where(pers=>pers.DepartmentId==id);
            // передаем все объекты в динамическое свойство Person в ViewBag
            ViewBag.Persons = persons;
            // возвращаем представление
            return View();
        }
    }

}