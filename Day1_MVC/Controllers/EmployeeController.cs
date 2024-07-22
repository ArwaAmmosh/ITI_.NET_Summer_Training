
using Microsoft.AspNetCore.Mvc;
namespace ST_WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult GetByID(int id)
        {
            Employee? emp = SampleData.Employees.Where(s => s.ID == id).SingleOrDefault();
            if (emp == null)
            {
                return Content("Student is not available.");
            }
            return View("Index1", emp);
        }

        public IActionResult GetAll()
        {
            List<Employee> emps = SampleData.Employees;
            return View("Index", emps);
            ;
        }
    } }