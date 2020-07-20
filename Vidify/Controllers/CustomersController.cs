using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidify.Controllers;
using System.Data.Entity;
using Vidify.Models;
using Vidify.ViewModels;
namespace Vidify.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult CustomerList()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();   //gets lost of cust from db 

            return View(customers);
        }

        public ActionResult Details(int Id)
        {

            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

       

    }
}
  