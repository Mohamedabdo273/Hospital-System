using Hospital_System.Data;
using Hospital_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Hospital_System.Controllers
{
    public class PatientController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            var patient = db.Patients.Select(x=>new {x.Doctor,x.Id,x.Name,x.TimeOnly,x.Appointment});
            return View(patient);
        }

        public IActionResult CreateNew(int id)
        {
            var doctor = db.Doctors.FirstOrDefault(x => x.Id == id);
            ViewBag.Name = doctor.Name;
            ViewBag.Id = doctor.Id;
            return View();
        }
        [HttpPost]
        public IActionResult CreateNew(Patient patient)
        {
            var doctor = db.Doctors.ToList();
            db.Patients.Add(patient);
            db.SaveChanges();           
            return RedirectToAction(nameof(Index));
            

        }
    }
}
