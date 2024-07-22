using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_MVC.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [NotMapped]

        [ForeignKey("Office")]
        public int? Office_ID { get; set; }    

        // Navigation Property
        public Office? office{ get; set; }
        public List<Emp_Projects>? Emp_Projects { get; set; } = new List<Emp_Projects>();
    }
}
