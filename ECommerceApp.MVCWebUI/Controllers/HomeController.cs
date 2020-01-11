using ECommerceApp.Entities;
using ECommerceApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceApp.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }      
        public ActionResult Index()
        {
            List<Product> products = _productService.GetAll();
            return View(products);
        }

        public ActionResult Details(int id = 0)
        {
            Product product = _productService.Get(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Error");
        }             
        public ActionResult List(int id = 0)
        {
            List<Product> products;
            if (id > 0) 
            {

                 products = _productService.GetProductsByCategoryId(id);
            }
            else
            {
                 products = _productService.GetAllWithShortDescrition();
            }
            
            return View(products);
        }
        public ActionResult Error()
        {
            return View();
        }
        public PartialViewResult _CategoryList()
        {
            List<Category> category = _categoryService.GetAll();
            return PartialView(category);
        }
    }
}