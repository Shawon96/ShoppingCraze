using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCraze.Web.Controllers
{
    public class CustomerHomeController : Controller
    {
        // GET: CustomerHome
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerHome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerHome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerHome/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerHome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerHome/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerHome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerHome/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
