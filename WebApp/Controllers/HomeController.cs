using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int yearOne, int yearTwo)
        {
            return RedirectToAction(
                "Results", 
                new { yearOne, yearTwo }
                );
        }

        public IActionResult Results(ResultsViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
