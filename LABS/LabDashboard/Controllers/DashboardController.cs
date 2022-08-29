using Microsoft.AspNetCore.Mvc;

namespace LabDashboard.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IDdetails()
        {
            return View();
        }
    }
}
