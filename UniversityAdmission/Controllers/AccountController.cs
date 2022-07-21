using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmission.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Sign()
        {
            return View();
        }

        public IActionResult forget()
        {
            return View();
        }
    }
}
