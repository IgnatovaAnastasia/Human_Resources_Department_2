using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Department
    {
        // department ID 
        [Key]
        public int Id { get; set; }
        // department name
        public string Name { get; set; }
    }
}