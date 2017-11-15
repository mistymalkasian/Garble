using Garble.Models;
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
        public ViewResult Index()
        {
            return View();
        }
    }
}