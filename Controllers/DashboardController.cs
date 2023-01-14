using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult DashIndex()
        {
            return View();
        }
    }
}
