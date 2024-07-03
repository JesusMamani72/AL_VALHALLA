using AL_VALHALLA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AL_VALHALLA.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }

}
