using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_MVC.Models
{
    public class Office

    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Location { get; set; }

        // Navigation Property
        public List<Employee>? Employees { get; set; } = new List<Employee>();
        public List<Project>? Projects { get; set; } = new List<Project>();
    }
}
