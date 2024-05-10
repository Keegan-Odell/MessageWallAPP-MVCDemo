using MessageWall.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace MessageWall.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int meow)
        {
            CounterModel model = new(meow);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnIncrement(int meow)
        {
            meow++;
            return RedirectToAction("Index", new { meow });
        }

        [HttpPost]
        public IActionResult OnDecrement(int meow)
        {
            meow--;
            return RedirectToAction("Index", new { meow });
        }
    }
}
