using Day_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day_MVC.Controllers
{
    public class projectController : Controller
    {
        CompanyContext context = new CompanyContext();
        [HttpGet]
        public IActionResult Add()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Add(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Project project = context.Projects.SingleOrDefault(c => c.Id == id);
            context.Projects.Remove(project);
            context.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Project project = context.Projects.SingleOrDefault(c => c.Id == id);
            return View(project);
        }
        [HttpPost]
        public IActionResult Edit(Project project)
        {
            Project Oldproject = context.Projects.SingleOrDefault(c => c.Id == project.Id);
            project.Description = project.Description;
            Oldproject.Name = project.Name;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            List<Project> projects = context.Projects.ToList();

            return View(projects);
        }
    }
}
