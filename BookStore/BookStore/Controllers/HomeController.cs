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
        /*using(DepartmentContext db = new DepartmentContext())
        {
            System.Data.SqlClient.SqlParameter param2 = new System.Data.SqlClient.SqlParameter("@Id", "@5");
            var person = db.Database.SqlQuery<Person>("SELECT * FROM Persons WHERE Id LIKE @Id", param2);
            foreach (var phone in person)
                Console.WriteLine(person.Name);
        }*/

        [HttpGet]
        public ActionResult All_person()
        {
            IEnumerable<Person> persons = db.Persons;
            // передаем все объекты в динамическое свойство Department в ViewBag
            ViewBag.Persons = persons;
            // возвращаем представление
            return View();
        }
    }

}