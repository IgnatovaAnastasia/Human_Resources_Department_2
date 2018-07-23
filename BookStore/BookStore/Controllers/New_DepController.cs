using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class New_DepController : Controller
    {
        DepartmentContext db = new DepartmentContext();
        [HttpGet]
        public ActionResult New_Dep()
        {
            return View();
        }
        [HttpPost]
        public string New_Dep(Department newD)
        {
            string res = "the Id is incorrect";
            IEnumerable<Department> departments = db.Departments;
            if (departments.All(dep => dep.Id != newD.Id))
            {
                db.Departments.Add(newD);
                // сохраняем в бд все изменения
                db.SaveChanges();
                res = newD.Name + " added to db sucassefully";
            }
            return res;
        }
    }
}