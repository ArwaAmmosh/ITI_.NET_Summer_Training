using Day_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_MVC.Controllers
{
    public class OfficeController : Controller
    {
        CompanyContext context = new CompanyContext();
        public IActionResult index1()
        {
            List<Office> offices = context.Offices.ToList();
            return View(offices);
        }

        public IActionResult AddFormOffice()
        {
            List<Office> offices = context.Offices.ToList();
            ViewBag.Offices = offices;
            return View();
        }
        public IActionResult AddToDBO(Office office)
        {
            context.Offices.Add(office);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            Office office = context.Offices.SingleOrDefault(c => c.Id == id);
            context.Offices.Remove(office);
            context.SaveChanges();
            return RedirectToAction("index");


        }
        public IActionResult EditFormOffice(int id)
        {
            Office office = context.Offices.SingleOrDefault(c => c.Id == id);
            List<Office> offices = context.Offices.ToList();
            ViewBag.Offices = offices;
            return View(office);
        }
        public IActionResult EditInDBOffice(Office office)
        {
            Office Oldoffice = context.Offices.SingleOrDefault(c => c.Id == office.Id);
            office.Location = office.Location;
            Oldoffice.name = office.name;
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
