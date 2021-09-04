using Microsoft.AspNetCore.Mvc;
using MyWebsiteResume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteResume.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "Marco";
            ViewBag.FV = 9999.99;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
    }
}
