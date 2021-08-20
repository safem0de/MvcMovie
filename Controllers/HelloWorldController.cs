using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // PART2 OF MICROSOFT TUTORIAL
        // GET: /HelloWorld/

        // public string Index()
        // {
        //     return "This is my default action...";
        // }

        // 
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome()
        // {
        //     return "This is the Welcome action method...";
        // }

        // public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }

        // public string Welcome(string name, int ID = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }

        // PART 3 OF MICROSOFT TUTORIAL
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}