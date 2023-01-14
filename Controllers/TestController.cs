using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
