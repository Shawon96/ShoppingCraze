using ShoppingCraze.BLL.Interfaces;
using ShoppingCraze.Entity.Models;
using ShoppingCraze.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCraze.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }
        // GET: Product
        public IEnumerable<Product> Index()
        {
            IEnumerable<Product> products= productService.GetAll().ToList();
            return products;
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            Product product = productService.Get(id);
            Category category = categoryService.Get(product.CategoryId);
            IEnumerable<Category> categories= categoryService.GetAll().ToList();
            string category1  = categories.Where(x => x.Id == product.Id).Select(x => x.CategoryName).ToString();
            ViewData["category"] = category.CategoryName;
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ProductViewModel productViewModel = new ProductViewModel
            {
                Product = new Product(),
                Categories = categoryService.GetAll(),
                AllProducts = productService.GetAll()
            };
            return View(productViewModel);

        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            Product product = productViewModel.Product;
            try
            {
                // TODO: Add insert logic here
                productService.Add(product);
                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return View(productViewModel);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = productService.Get(id);
            ProductViewModel productViewModel = new ProductViewModel
            {
                Product = product,
                Categories = categoryService.GetAll()
            };
            return View(productViewModel); 
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductViewModel productViewModel)
        {
            Product product = productViewModel.Product;
            try
            {
                // TODO: Add update logic here
                productService.Edit(product);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(productViewModel);
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            Product product = productService.Get(id);
            Category category = categoryService.Get(product.CategoryId);
            IEnumerable<Category> categories = categoryService.GetAll().ToList();
            string category1 = categories.Where(x => x.Id == product.Id).Select(x => x.CategoryName).ToString();
            ViewData["category"] = category.CategoryName;
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = productService.Get(id);
            try
            {
                productService.Delete(product);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(product);
            }
        }
    }
}
