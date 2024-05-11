using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ViewResult aboutUs()
        {
            return View();
        }
        public ViewResult refundpolicy()
        {
            return View();
        }

        public ViewResult contactUs()
        {
            return View();
        }

        public ViewResult checkout()
        {
            return View();
        }
        public ViewResult addtocart()
        {
            return View();
        }


    }
}
