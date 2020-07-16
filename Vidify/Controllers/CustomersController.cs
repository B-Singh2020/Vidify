using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidify.Controllers;
using Vidify.Models;
using Vidify.ViewModels;
namespace Vidify.Controllers
{
    public class CustomersController : Controller
    {

        public ActionResult CustomerList()
        {
            var customers = GetCustomers();   //create list of cust obj

            return View(customers);
        }

        public ActionResult Details(int Id)
        {

            var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{ Name = "Bob", Id  = 1},
                new Customer {Name = "Rob", Id  = 2},
                new Customer{ Name = "Hob", Id  = 3},
                new Customer {Name = "Terry", Id  = 4},
                new Customer{ Name = "Berry", Id  = 5 },
                new Customer {Name = "Cherry", Id = 6 }
            };
        }

    }
}
  