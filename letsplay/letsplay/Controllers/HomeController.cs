using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace letsplay.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			ViewData["Message"] = "This is your login page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is your about page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "This is your contact page.";

            return View();
        }

		public IActionResult Login()
		{
			ViewData["Message"] = "This is your login page.";

			return View();
		}

		public IActionResult Error()
        {
            return View();
        }
    }
}
