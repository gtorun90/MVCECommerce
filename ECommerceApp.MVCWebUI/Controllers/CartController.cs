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
        private IProductService _productService;
        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            return View(GetCart());
        }        
        public ActionResult AddToCart(int productId = 0)
        {
            var product = _productService.Get(productId);
            if (product != null)
            {
                GetCart().AddToCart(product,1);
            }
            return RedirectToAction("Index");
        }        
        public ActionResult RemoveCart(int productId = 0)
        {
            var product = _productService.Get(productId);
            if (product != null)
            {
                GetCart().RemoveFromCart(product);
            }
            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;

        }
    }
}