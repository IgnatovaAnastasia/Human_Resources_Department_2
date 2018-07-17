using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class DepartmentDbInitializer : DropCreateDatabaseIfModelChanges<DepartmentContext>//DropCreateDatabaseAlways<DepartmentContext>
    {
        protected override void Seed(DepartmentContext db)
        {
            base.Seed(db);
        }
    }
}