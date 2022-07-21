using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmission.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
