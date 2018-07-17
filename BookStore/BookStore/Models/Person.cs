using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Person
    {
        // person ID 
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
        // department ID 
        [Key]
        public int DepartmentId { get; set; }
    }
}