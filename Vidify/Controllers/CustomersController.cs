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
            var customers = new List<Customer>   //create list of cust obj
            {
                new Customer{ Name = "Bob"},
                new Customer {Name = "Rob"},
                new Customer{ Name = "Hob"},
                new Customer {Name = "Terry"},
                new Customer{ Name = "Berry"},
                new Customer {Name = "Cherry"}
            };
                        //customer view model

            

            var viewMod = new CustomersListViewModel
            {
                Customers = customers
            };
            return View(viewMod);
        }
    }
}