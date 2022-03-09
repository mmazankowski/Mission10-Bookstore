using System;
using Microsoft.AspNetCore.Mvc;
using Mission10_Bookstore.Models;

namespace Mission10_Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}


