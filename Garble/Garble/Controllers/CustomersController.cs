﻿using Garble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garble.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        // GET: Customers

            public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult SchedulePickup()
        {
           
            return View();
        }

        public ActionResult PickupLog()
        {
            return View();
            
        }

        [HttpPost]
        public ActionResult SaveChanges()
        {
            _context.SaveChanges();

            return View();
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerID == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            else
            {
                return View(customer);
            }
        }

    }
}