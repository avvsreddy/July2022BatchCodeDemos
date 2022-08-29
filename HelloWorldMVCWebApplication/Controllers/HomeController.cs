using HelloWorldMVCWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloWorldMVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        // http://domainname.com/home/index
        public IActionResult Index()
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


        public IActionResult abcd()
        {
            //return "<h1>Hello World!</h1>";
            return View();
        }
    }
}