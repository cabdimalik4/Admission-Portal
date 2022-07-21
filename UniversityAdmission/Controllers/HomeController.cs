using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
