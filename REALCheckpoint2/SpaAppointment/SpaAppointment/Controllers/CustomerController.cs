﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaAppointment.Models;
using SpaAppointment.Services;

namespace SpaAppointment.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository repo = new CustomerRepository();
        // GET: Customer
        public ActionResult Index()
        {
            return View(repo.Customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.GetCustomer(id));
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customers)
        {
            try
            {
                // TODO: Add insert logic here
                repo.Add(customers);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repo.GetCustomer(id) );
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customers)
        {
            try
            {
                // TODO: Add update logic here
                repo.Update(id, customers);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repo.GetCustomer(id));
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer collection)
        {
            try
            {
                // TODO: Add delete logic here
                repo.DeleteCustomer(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}