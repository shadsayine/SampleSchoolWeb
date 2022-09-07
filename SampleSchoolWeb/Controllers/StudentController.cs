using Microsoft.AspNetCore.Mvc;
using SampleSchoolWeb.Data;
using SampleSchoolWeb.Models;

namespace SampleSchoolWeb.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> objStudentList = _db.SchoolDB;
            return View(objStudentList);
        }
    }
}
