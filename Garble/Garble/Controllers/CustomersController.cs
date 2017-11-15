using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Garble.Models;

namespace Garble.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //if (!pageIndex.HasValue)
            //    pageIndex = 1;

            //if (String.IsNullOrWhiteSpace(sortBy))
            //    sortBy = "Name";

            //return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

            var Customer = new Customer() { FirstName = "Misty", LastName = "Malkasian" };
            return View(Customer);
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}

       
    }
}