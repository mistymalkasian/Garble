using Garble.Models;
using Garble.ViewModels;
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

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerID == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,

            };
            return View("New", viewModel);
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
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel()
                {
                    Customer = customer
                };
                return View("CustomerForm", viewModel);
            }

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

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

    }
}