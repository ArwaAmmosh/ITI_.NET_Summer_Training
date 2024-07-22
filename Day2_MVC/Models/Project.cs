using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_MVC.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int? DepartmentId { get; set; }

        public Office? office { get; set; }
        public List<Emp_Projects>? EmpProjects { get; set; } = new List<Emp_Projects>();
    }
}
