using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastracture;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepo repo;

        public StudentController(IStudentRepo _repo) 
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            var items = repo.GetallStudent();
            return View(items);
        }
        public IActionResult Details(int id) 
        { 
            var item = repo.GetStudentByID(id);
            return View(item);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            var d = repo.InsertData(model);
            return RedirectToAction("Index");

            return View(d);
        }

    }
}
