using Hospital_System.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_System.Controllers
{
    public class DoctorController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {           
            var Doctors = db.Doctors.ToList();           
            return View(Doctors);
            
        }
    }
}
