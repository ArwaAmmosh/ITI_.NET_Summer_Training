using Day_MVC.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_MVC.ViewModels
{
    public class EmployeeData
    {
        public int ID { get; set; }
        [Required (ErrorMessage ="Is Required")]
        [StringLength(50 ,ErrorMessage ="The Name is too long") ]
        [MinLength(5, ErrorMessage = "The Name is too Short")]
        public string Name { get; set; }
        [Range(25, 40, ErrorMessage = "Age out of the Range (25,40)")]
        public int Age { get; set; }
        public decimal Salary { get; set; }
        [EmailAddress(ErrorMessage = "not the correct sequence")]

        public string Email { get; set; }
        [MinLength(5, ErrorMessage = "The Address is too Short")]
        public string Address { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage = "The Password is not matching")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Office")]
        public int Office_ID { get; set; }
        [ValidateNever]

        public SelectList office { get; set; }

    }
}
