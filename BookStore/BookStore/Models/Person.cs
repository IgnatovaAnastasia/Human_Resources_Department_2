using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Person
    {
        // person ID 
        [Key]
        public int PersonId { get; set; }
        // имя и фамилия
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string LastName { get; set; }
        [StringLength(200)]
        public string FatherName { get; set; }
        // Day of birth
        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set; }

        // department ID 
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}