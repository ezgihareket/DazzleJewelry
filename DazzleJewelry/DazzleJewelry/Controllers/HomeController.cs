using DazzleJewelry.Models;
using DazzleJewelry.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJewelryRepository _jewelryRepository;

        public HomeController(IJewelryRepository jewelryRepository)
        {
            _jewelryRepository = jewelryRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                JewelryOnSale = _jewelryRepository.GetJewelryOnSale
            };
            return View(homeViewModel);
        }
    }
}
