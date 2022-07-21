using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmission.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dash()
        {
            return View();
        }
    }
}
