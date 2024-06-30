using Microsoft.AspNetCore.Mvc;

namespace Hospital.Web.Areas.Patient.Controllers
{
    [Area("Patient")]
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}