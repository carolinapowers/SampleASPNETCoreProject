using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleASPNetCoreProject.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var model = 12345;

            return View(model);
        }

        public IActionResult BreakStuff()
        {
            int number = "dog";
            return View();
        }
    }
}
