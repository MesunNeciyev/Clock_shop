using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Clock_Shop.Models;

namespace Clock_Shop.HomeController
{
    public class HomeController:Controller
    {
        private readonly IClockRepistory _clockRepisotry;

        public HomeController(IClockRepistory clockRepository)
        {
            _clockRepisotry = clockRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult Shopping()
        {
            IEnumerable<Clock> clocks = _clockRepisotry.GetAllClocks();
            return View(clocks);
        }
    }
}
