using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcLab.Models;

namespace MvcLab.Controllers
{
    public class CarsCtrl : Controller
    {

        public IActionResult Index()
        {
            return View(Car.GetCars());
        }
        public IActionResult Details(string Model)
        {
            var car = Car.GetCars().Find(x => x.Model == Model);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

    }
}