using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Department
    {
        // department ID 
        [Key]
       // [Column(Order = 1)]
        public int Id { get; set; }
        // department name
        [StringLength(200)]
        public string Name { get; set; }

        public ICollection<Person> Persons { get; set; }
    }
}