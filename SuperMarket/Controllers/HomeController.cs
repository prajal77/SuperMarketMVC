using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;
using System.Diagnostics;

namespace SuperMarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
