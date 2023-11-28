using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcLab4.Context;
using MvcLab4.Models;

namespace MvcLab4.Controllers {
    public class TheCtrl : Controller {
        
        public AcademyContext Context { get; set; }
        public TheCtrl(AcademyContext context) {
            Context = context;
        }
        public IActionResult Index() {
            return View();
        }
        public IActionResult ShowStudents() 
        {
            var students = Context.Students.ToList();
            return View(students);
        }
        public IActionResult ShowCourses() {
            var courses = Context.Courses.ToList();
            return View(courses);
        }
        public IActionResult AddStudentForm() {
            var CoursesList = Context.Courses.Select(c => new SelectListItem(c.Name,c.CourseId.ToString()));
            ViewBag.Courses = CoursesList;
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(string name, int age, string email, int courseID) {
            Student newStudent = new() {
                Name = name,
                Age = age,
                Email = email,
                CourseId = courseID
            };
            Context.Students.Add(newStudent);
            Context.SaveChanges();
            return RedirectToAction("ShowStudents");
        }
        public IActionResult AddCourseForm() {
            return View();
        }
        [HttpPost]
        public IActionResult AddCourse(string name, string description) {
            Course new_course = new() {
                Name = name,
                Description = description
            };
            Context.Courses.Add(new_course);
            Context.SaveChanges();
            return RedirectToAction("ShowCourses");
        }
        public IActionResult EditStudentForm(int id) {
            var student = Context.Students.Find(id);
            if (student == null) {
                return NotFound();
            }
            var CoursesList = Context.Courses.Select(c => new SelectListItem(c.Name,c.CourseId.ToString()));
            ViewBag.Courses = CoursesList;
            return View(student);
        }
        [HttpPost]
        public IActionResult EditStudent(Student student) {
            var EditedStudent = Context.Students.Select(s => s).FirstOrDefault(s => s.StudentId == student.StudentId);
            if (EditedStudent == null) {
                return NotFound($"Student{student.StudentId} not found");
            }
            EditedStudent.Name = student.Name;
            EditedStudent.Age = student.Age;
            EditedStudent.Email = student.Email;
            EditedStudent.CourseId = student.CourseId;
            Context.Students.Update(EditedStudent);
            Context.SaveChanges();
            return RedirectToAction("ShowStudents");
        }
        public IActionResult EditCourseForm(int id) {
            var course = Context.Courses.Find(id);
            return View(course);
        }
        [HttpPost]
        public IActionResult EditCourse(Course course) {
            var Editedcourse = Context.Courses.Select(c => c).FirstOrDefault(c => c.CourseId == course.CourseId);
            if (Editedcourse == null) {
                return NotFound("Course not found");
            }
            Editedcourse.Name = course.Name;
            Editedcourse.Description = course.Description;
            Context.SaveChanges();
            return RedirectToAction("ShowCourses");
        }
        public IActionResult DeleteStudent(int id) {
            var student = Context.Students.FirstOrDefault(s => s.StudentId == id);
            if (student == null) {
                return NotFound();
            }
            Context.Students.Remove(student);
            Context.SaveChanges();
            return RedirectToAction("ShowStudents");
        }
        public IActionResult DeleteCourse(int id) {
            var course = Context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null) {
                return NotFound();
            }
            Context.Courses.Remove(course);
            Context.SaveChanges();
            return RedirectToAction("ShowCourses");
        }
        public IActionResult CourseInfo(int id) {
            var course = Context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null) {
                return NotFound();
            }
            var students = Context.Students.Where(s => s.CourseId == course.CourseId).ToList();
            ViewBag.Students = students;
            return View(course);
        }
        public IActionResult StudentInfo(int id) {
            var student = Context.Students.FirstOrDefault(s => s.StudentId == id);
            if (student == null) {
                return NotFound();
            }
            var course = Context.Courses.FirstOrDefault(c => c.CourseId == student.CourseId);
            ViewBag.Course = course;
            return View(student);
        }
    }
}