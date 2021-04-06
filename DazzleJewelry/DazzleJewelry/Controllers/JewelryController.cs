using DazzleJewelry.Models;
using DazzleJewelry.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Controllers
{
    public class JewelryController : Controller
    {

        private readonly IJewelryRepository _jewelryRepository;
        private readonly ICategoryRepository _categoryRepository;

        public JewelryController(IJewelryRepository jewelryRepository, ICategoryRepository categoryRepository)
        {
            _jewelryRepository = jewelryRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {

            // return View(_jewelryRepository.GetAllJewelry);
            var jewelryListViewModel = new JewelryListViewModel();
            jewelryListViewModel.Jewelries = _jewelryRepository.GetAllJewelry;
            jewelryListViewModel.CurrentCategory = "En Çok Satılanlar";
            return View(jewelryListViewModel);
            
        }
    }
}
