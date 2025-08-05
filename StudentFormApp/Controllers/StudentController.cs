using Microsoft.AspNetCore.Mvc;
using StudentFormApp.Data;
using StudentFormApp.Models;
using System.Linq;

namespace StudentFormApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult DisplayForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayForm(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(model);
                _context.SaveChanges();
                return RedirectToAction("GetAllStudent");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult GetAllStudent()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        // GET: /Student/Edit/5
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: /Student/Edit/5
        [HttpPost]
        public IActionResult Edit(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(model);
                _context.SaveChanges();
                return RedirectToAction("GetAllStudent");
            }
            return View(model);
        }

        // GET: /Student/Delete/5
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("GetAllStudent");
        }

    }
}
