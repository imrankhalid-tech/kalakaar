using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kalakaar.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Kalakaar.Data;

namespace Kalakaar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var wishlist = new Wishlist() { Id=1};
            wishlist.ProductIDs = new List<int>();
            HttpContext.Session.SetString("wishlist", JsonConvert.SerializeObject(wishlist));

            var checkout = new Checkout() { Id = 1 };
            checkout.ProductIDs = new List<int>();
            HttpContext.Session.SetString("checkout", JsonConvert.SerializeObject(checkout));

            return View();
        }

        public IActionResult Partner()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
