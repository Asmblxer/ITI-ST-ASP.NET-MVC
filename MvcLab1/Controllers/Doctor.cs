using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcLab.Models;

namespace MvcLab.Controllers
{
    public class DoctorController : Controller
    {
        // 
        // GET: /Doctor/

        public IActionResult Index()
        {
            List <Doctor> doctors = Doctor.GetDoctors();
            return View(doctors);   
        }
    }
}