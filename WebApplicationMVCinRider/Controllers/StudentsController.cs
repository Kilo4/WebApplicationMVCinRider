using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationMVCinRider.Controllers
{
    public class StudentsController : Controller
    {
        // GET
        public IActionResult Students()
        {
            List<Models.Students.Students> _lsStudentses = new List<Models.Students.Students>();
            for (int i = 0; i < 3; i++)
            {
                _lsStudentses.Add(AddStudents()); 
            }
            
            ViewBag.Message = _lsStudentses;
            return View();
        }

        protected Models.Students.Students AddStudents()
        {
            Models.Students.Students _students = new Models.Students.Students();
            

            _students.FirstName = "a";
            _students.LastName = "b";

            return _students;
        }
    }
}