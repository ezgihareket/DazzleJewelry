using DazzleJewelry.Filter;
using DazzleJewelry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Controllers
{
    [AdminFilter]
    public class AdminController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IJewelryRepository _jewelryRepository;
        private readonly IOrderRepository _orderRepository;

        public AdminController(ICategoryRepository categoryRepository, IJewelryRepository jewelryRepository, IOrderRepository orderRepository)
        {
            _categoryRepository = categoryRepository;
            _jewelryRepository = jewelryRepository;
            _orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jewelrys()
        {
            return View(_jewelryRepository.GetAllJewelry);
        }

        public IActionResult JewelryPage(int? id)
        {
            Jewelry jewelry = new Jewelry();
            if (id.HasValue)
            {
                jewelry = _jewelryRepository.GetJewelryById(id.Value);
            }
            ViewBag.categoryId = _categoryRepository.GetAllCategories
            .Select(c => new SelectListItem
            {
                Text = c.CategoryName,
                Value = c.CategoryId.ToString()
            }).ToList();
            return View(jewelry);
        }

        [HttpPost]
        public async Task<IActionResult> JewelrySave(Jewelry jewelry)
        {
            if (jewelry != null)
            {
                var file = Request.Form.Files.First();
                string savePath = Path.Combine("wwwroot", "images");
                var fileName = $"{DateTime.Now:MMddHHmmss}.{file.FileName.Split(".").Last()}";
                var fileUrl = Path.Combine(savePath, fileName);
                using (var fileStream = new FileStream(fileUrl, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                jewelry.ImgUrl = "\\images\\" + fileName;
                jewelry.ImgThumUrl = "\\images\\thumbnails\\" + fileName;
                _jewelryRepository.SaveJewelry(jewelry);
            }
            return Redirect("Jewelrys");
        }
        public IActionResult Category()
        {
            return View(_categoryRepository.GetAllCategories);
        }

        public IActionResult Orders()
        {
            return View(_orderRepository.getAll());
        }

        public IActionResult DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
            return RedirectToAction("Orders");
        }

        public IActionResult CreateCategory(Category category)
        {
            _categoryRepository.CreateCategory(category);
            return Redirect("Category");
        }
        public IActionResult DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return RedirectToAction("Category");
        }
    }
}
