using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_MVC.Models
{
    [PrimaryKey("Emp_ID", "Proj_ID")]
    public class Emp_Projects
    {
        public int Emp_ID { get; set; }
        public int Proj_ID { get; set; }
        public int Working_Hours { get; set; }
        [ForeignKey("Emp_ID")]
        public Employee Employee { get; set; }
        [ForeignKey("Proj_ID")]
        public Project Project { get; set; }
    }
}
