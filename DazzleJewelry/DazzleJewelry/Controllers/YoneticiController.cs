using DazzleJewelry.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Controllers
{
    public class YoneticiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(LoginDto loginDto)
        {
            if (loginDto.Username == "ezgihareket" && loginDto.Password == "admin")
            {
                HttpContext.Session.SetInt32("id", 10);
                return RedirectToAction("Index", "Admin");

            }
            return RedirectToAction("Index", "Home");
        }
    }
}
