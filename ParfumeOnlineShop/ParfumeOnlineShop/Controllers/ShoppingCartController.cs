using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParfumeOnlineShop.Interfaces;
using ParfumeOnlineShop.Models;
using ParfumeOnlineShop.ViewModel;

namespace ParfumeOnlineShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IParfumeRepository _parfumeRepository;

        public ShoppingCartController(ShoppingCart shoppingCart, IParfumeRepository parfumeRepository)
        {
            _shoppingCart = shoppingCart;
            _parfumeRepository = parfumeRepository;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
          

            _shoppingCart.ShoppingCartItems = items;

            ShoppingCartItem item = new ShoppingCartItem();
           
            var shoppingCartViewModel = new ShoppingCartViewModel {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

       public RedirectToActionResult AddToShoppingCart(int parfumeId)
        {
            var selectedParfume = _parfumeRepository.Parfumes.FirstOrDefault(p => p.ParfumeId == parfumeId);

            if (selectedParfume != null)
            {
                _shoppingCart.AddToCart(selectedParfume, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int parfumeId)
        {
            var selectedParfume = _parfumeRepository.Parfumes.FirstOrDefault(p => p.ParfumeId == parfumeId);

            if (selectedParfume != null)
            {
                _shoppingCart.RemoveFromCart(selectedParfume);
            }
            return RedirectToAction("Index");
        }
    }
}