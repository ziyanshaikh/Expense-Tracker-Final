using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpenseTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //AppDbContext db = new AppDbContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var cat = getCategories();
            //var exp = getExpenses();
            //MultiModelData data = new MultiModelData();
            //data.myCategory = cat;
            //data.myExpense = exp;
            //AppDbContext db = new AppDbContext();

            return View();
        }

        //public PartialViewResult Categorys()
        //{
          
        //    return PartialView("_category", cat);
        //}

        //public PartialViewResult Expensess()
        //{
            
        //    return PartialView("_expense", exp);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        //public List<Category> getCategories()
        //{
        //    return db.Categories.ToList();
        //}

        //public List<Expense> getExpenses()
        //{
        //    return db.Expenses.ToList();
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}