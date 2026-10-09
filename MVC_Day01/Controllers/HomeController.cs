using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Day01.Models;

namespace MVC_Day01.Controllers
{
    public class HomeController : Controller
    {


        // /Home/ShowMsg
        public string ShowMsg()
        {
            return "Hello World";
        }

        // /Home/ShowMsg2
        public ContentResult ShowMsg2()
        {
            // Complex data type !
            // decalre
            ContentResult result = new ContentResult();
            // initial
            result.Content = "Hello World";
            // return
            return result;
        }

       
        // /Home/ShowView
        public ViewResult ShowView()
        {
            // declare
            ViewResult result = new ViewResult();
            // initial
            result.ViewName = "View1";
            // return
            return result;
        }


        // /Home/ShowMix?id=2
        public IActionResult ShowMix(int id)
        {
            if (id % 2 == 0)
            {
                return View("View1");
            }
            else
            {
                return Content("Hello World");
            }
        }










        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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
