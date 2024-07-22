using Day_MVC.Models;
using Day_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Day_MVC.Controllers
{
    public class ValidationController : Controller
    {
        CompanyContext context = new CompanyContext();

        [HttpGet]
        public IActionResult Add()
        {
         
            EmployeeData emp = new EmployeeData()
            {
                  office = new SelectList(context.Offices.ToList(), "Id", "name")

            };
            return View(emp);
        }
        [HttpPost]
        public IActionResult Add(EmployeeData emp)
        {
            if (ModelState.IsValid)
            {
                Employee emp1 = new Employee()
                {
                    ID = emp.ID,
                    Name = emp.Name,
                    Salary = emp.Salary,
                    Age = emp.Age,
                    Email = emp.Email,
                    Office_ID = emp.Office_ID,

                };
                context.Employees.Add(emp1);
                context.SaveChanges();
                return RedirectToAction("index", "Employee");
            }
            else
            {
                emp.office=new SelectList(context.Offices.ToList(),"Id","name");
                return View(emp);
            }
        }
    }
}
