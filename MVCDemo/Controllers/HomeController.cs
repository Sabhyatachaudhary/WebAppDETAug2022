using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Filters;
using MVCDemo.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Helo(string name, string loc,string contact)
        {
            ViewBag.UserName = name;
            ViewBag.Location = loc;
            ViewBag.Contact = contact;
            return View();

        }
        [MyLog]
    public string CSRetest()
        {
            return "C# retest is scheduled today @5pm; get prepared";
        }
        [ResponseCache(Duration =10)]
        [MyLog]
        public string Retest()
        {
            return DateTime.Now.ToString();
        }
        //[Authorize]
        [MyLog]
        public string[]retests()
        {
            return new string[] { "c#-8-Sep", "TSQL=12-sep" };
        }
        [MyLog]
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
    }
}