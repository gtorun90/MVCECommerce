using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECommerceApp.Bll.Abstract;
using ECommerceApp.Dal.Concrete.EntityFrameWork;
using ECommerceApp.Entities;

namespace ECommerceApp.MVCWebUI.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: Category
        public ActionResult Index()
        {
            List<Category> categories = _categoryService.GetAll();
            return View(categories);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] Category category)
        {
            if (ModelState.IsValid)
            {
               _categoryService.Add(category);
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id = 0)
        { 
            Category category = _categoryService.Get(id);
            if (category == null)
            {
                return RedirectToAction("Error");
            }
            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id = 0)
        {
            Category category = _categoryService.Get(id);
            if (category == null)
            {
                return RedirectToAction("Error");
            }
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id = 0)
        {
            Category category = _categoryService.Get(id);
            _categoryService.Delete(category);
            return RedirectToAction("Index");
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}
