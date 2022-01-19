using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    public class YahtzeeController : Controller
    {
        public IActionResult Index()
        {
            //throw new IndexOutOfRangeException();
            return View();
        }
        [HttpGet] //create an attribute for the get method
        public IActionResult FanMail ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FanMail(FanMailModel model) // this is method overloading
        {
            return View();
        }
    }
}
