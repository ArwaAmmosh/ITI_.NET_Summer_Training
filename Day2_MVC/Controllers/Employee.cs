using Day_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyContext context=new CompanyContext();
        public IActionResult index()
        {
            List<Employee> employees = context.Employees.ToList();
             return View(employees);
        }

        public IActionResult AddForm()
        {
            List<Office> office = context.Offices.ToList();
            ViewBag.Offices = office;
            return View();
        }
       public IActionResult AddToDB(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
          Employee emp = context.Employees.SingleOrDefault(c => c.ID == id);
            context.Employees.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("index");


        }
        public IActionResult EditForm(int id)
        {
            Employee emp = context.Employees.SingleOrDefault(c => c.ID == id);
            List<Office> office = context.Offices.ToList();
            ViewBag.Offices = office;
            return View(emp);
        }
        public IActionResult EditInDB(Employee emp)
        {
            Employee Oldemp = context.Employees.SingleOrDefault(c => c.ID == emp.ID);
            Oldemp.Name = emp.Name;
            Oldemp.Salary = emp.Salary;
            Oldemp.Email = emp.Email;
            Oldemp.Age = emp.Age;
            Oldemp.Password = emp.Password;
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
