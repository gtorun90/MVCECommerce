using ECommerceApp.Entities;
using ECommerceApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        public ActionResult Index()
        {
            return View(GetCart());
        }        
        public ActionResult AddToCart(int id = 0)
        {
            var product = _cartService.Get(id);
            if (product != null)
            {
                _cartService.Add(product,1);
                //GetCart();
            }
            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = _cartService.GetCarts();
                Session["Cart"] = cart;
            }
            return cart;

        }
    }
}