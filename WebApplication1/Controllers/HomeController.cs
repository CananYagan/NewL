using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace NewL.MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }



    }
}