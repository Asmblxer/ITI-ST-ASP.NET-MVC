using Microsoft.AspNetCore.Mvc;
using MVC_Lab3.Models;

namespace MVC_Lab3.Controllers
{
    public class Person : Controller
    {
        public static List<Models.Person> Persons = Models.Person.GetPersons();
        public IActionResult Index()
        {
            return View(Persons);
        }
        [HttpPost]
        public IActionResult Add (int Id, string Name, int Age, string Image)
        {
            Persons.Add(new Models.Person { Id = Id, Name = Name, Age = Age, Image = Image });
            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddForm()
        {
            return View();
        }
        public IActionResult Details(int Id)
        {
            var Person = Persons.Find(x => x.Id == Id);
            if (Person == null)
            {
                return View("Error");
            }
            return View(Person);
        }
        public IActionResult Delete(int Id)
        {
            var DeletedPerson = Persons.Find(x => x.Id == Id);
            if (DeletedPerson == null)
            {
                return View("Error");
            }
            Persons.Remove(DeletedPerson);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int Id, string Name, int Age, string Image)
        {
            var EditedPerson = Persons.Find(x => x.Id == Id);
            if (EditedPerson == null)
            {
                return View("Error");
            }
            EditedPerson.Name = Name;
            EditedPerson.Age = Age;
            EditedPerson.Image = Image;
            return RedirectToAction(nameof(Index));
        }
        public IActionResult EditForm(int Id)
        {
            var EditedPerson = Persons.Find(x => x.Id == Id);
            if (EditedPerson == null)
            {
                return View("Error");
            }
            return View(EditedPerson);
        }
    }
}