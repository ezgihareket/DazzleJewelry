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

        public ViewResult List(string category)
        {
            IEnumerable<Jewelry> jeweleries;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                jeweleries = _jewelryRepository.GetAllJewelry.OrderBy(c => c.JewelryId);
                currentCategory = "Tüm Takılar";

            }
            else
            {
                jeweleries = _jewelryRepository.GetAllJewelry.Where(c => c.Category.CategoryName == category);
                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new JewelryListViewModel
            {
                Jewelries = jeweleries,
                CurrentCategory = currentCategory,
            });
        }

        public IActionResult Details(int id)
        {
            var jewelry = _jewelryRepository.GetJewelryById(id);
            if (jewelry == null)
            {
                return NotFound();
            }
            return View(jewelry);
        }
    }
}
