using ShoppingCraze.BLL.Interfaces;
using ShoppingCraze.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCraze.Web.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        // GET: Category
        public ActionResult Index()
        {
            IEnumerable<Category> category = categoryService.GetAll();
            return View(category);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            Category category = categoryService.Get(id);
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            Category category = new Category();
            return View(category);
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here
                categoryService.Add(category);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(category);
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            Category category = categoryService.Get(id);
            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                // TODO: Add update logic here
                categoryService.Edit(category);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(category);
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            Category category = categoryService.Get(id);
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Category category = categoryService.Get(id);
            try
            {
                // TODO: Add delete logic here
                categoryService.Delete(category);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(category);
            }
        }
    }
}
