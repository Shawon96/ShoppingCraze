using ShoppingCraze.BLL.Interfaces;
using ShoppingCraze.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCraze.Web.Controllers
{
    public class AdminController : Controller
    {
        private IAdminService adminService;
        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }
        // GET: Admin
        public ActionResult Index()
        {
            IEnumerable<Admin> admin = adminService.GetAll();
            return View(admin);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            Admin admin = adminService.Get(id);
            return View(admin);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            Admin admin = new Admin();
            return View(admin);
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Admin admin  )
        {
            try
            {
                // TODO: Add insert logic here
                adminService.Add(admin);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(admin);
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            Admin admin = adminService.Get(id);
            return View(admin);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Admin admin)
        {
            try
            {
                // TODO: Add update logic here
                adminService.Edit(admin);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(admin);
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            Admin admin = adminService.Get(id);
            return View(admin);
        }

        // POST: Admin/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin admin= adminService.Get(id);
            try
            {
                // TODO: Add delete logic here
                adminService.Delete(admin);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(admin);
            }
        }
    }
}
