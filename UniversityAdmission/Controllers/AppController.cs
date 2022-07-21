using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmission.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Application()
        {
            return View();
        }
    }
}
