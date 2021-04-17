using DazzleJewelry.Models;
using DazzleJewelry.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IJewelryRepository _jewelryRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IJewelryRepository jewelryRepository, ShoppingCart shoppingCart)
        {
            _jewelryRepository = jewelryRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int jewelryId)
        {
            var selectedJewelry = _jewelryRepository.GetAllJewelry.FirstOrDefault(c => c.JewelryId == jewelryId);
            if (selectedJewelry != null)
            {
                _shoppingCart.AddToCart(selectedJewelry, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int jewelryId)
        {
            var selectedJewelry = _jewelryRepository.GetAllJewelry.FirstOrDefault(c => c.JewelryId == jewelryId);
            if (selectedJewelry != null)
            {
                _shoppingCart.RemoveFromCart(selectedJewelry);
            }
            return RedirectToAction("Index");
        }
    }
}
