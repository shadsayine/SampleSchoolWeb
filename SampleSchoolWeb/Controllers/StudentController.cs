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

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.SchoolDB.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //EDIT
        //GET
        public IActionResult Edit(int ? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var studentFromDb = _db.SchoolDB.Find(id);

            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }

        //POST
        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.SchoolDB.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //DELETE
        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var studentFromDb = _db.SchoolDB.Find(id);

            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }

        //POST
        [HttpPost]
        public IActionResult DeletePOST(int ? id)
        {
            var obj = _db.SchoolDB.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.SchoolDB.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
