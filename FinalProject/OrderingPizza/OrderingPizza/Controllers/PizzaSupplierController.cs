using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderingPizza.Controllers
{
    public class PizzaSupplierController : Controller
    {
        // GET: PizzaSupplier
        public ActionResult Index()
        {
            return View();
        }

        // GET: PizzaSupplier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaSupplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaSupplier/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaSupplier/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaSupplier/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaSupplier/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaSupplier/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}