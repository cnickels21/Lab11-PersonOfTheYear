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

        // 2. Call GetPersons here to push data through to the view
        public IActionResult Results(int yearOne, int yearTwo)
        {
            return View(TimePerson.GetPersons(yearOne, yearTwo));
        }
    }
}
