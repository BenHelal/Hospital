using Microsoft.AspNetCore.Mvc;

namespace Hospital.Web.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class IdentityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}