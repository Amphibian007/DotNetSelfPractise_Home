using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validation2.Models
{
    public class Employee
    {
        [Required]
       
        public string Name { get; set; }
        [Required]
        public string  Designation { get; set; }
    }
}
