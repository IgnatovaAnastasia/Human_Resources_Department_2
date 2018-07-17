using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext() :base("DepartmentContext")
        { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
    /*using(DepartmentContext db = new DepartmentContext())
    {
        System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@Id", "%111%");
        var people = db.Database.SqlQuery<Person>("SELECT * FROM Persons WHERE Id LIKE @id", param);
        foreach (var phone in people)
            Console.WriteLine(people.Name);
    }*/
}