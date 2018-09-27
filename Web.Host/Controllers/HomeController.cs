using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Host.Models;

namespace Web.Host.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "你的应用程序描述页面！";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "你的联系方式页面";

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
