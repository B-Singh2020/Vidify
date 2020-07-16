using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidify.Models;
using Vidify.ViewModels;

namespace Vidify.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()  // returns movies list
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()  // list of movies 
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        // GET: Movies/Random , this action will get random movie
       /* public ActionResult Random()
        {
            var movie = new Movie() { Name = "Puss in Boots"};
            var customers = new List<Customer>   //create list of cust obj
            {
                new Customer{ Name = "cust 1"},
                new Customer {Name = "cust 2"},
                new Customer{ Name = "cust 3"},
                new Customer {Name = "cust 4"},
                new Customer{ Name = "cust 5"},
                new Customer {Name = "cust 6"}
            };

            var viewMod = new RandomMovieViewModel   //create viewmodel and assign movie and list
            {
                Movie = movie,
                Customers = customers

            };

            return View(viewMod);                            //return corresponding view created for method pass viewmodel
        }

        public ActionResult Edit(int Id)  // Action used to test url and query string input
        {
            return Content("Id =" + Id);  //returns string id 
        }

        // page to display all movies in database (learning about optional parameters)
        // add '?' to int to make it nullable and string is already
        public ActionResult Index(int? pageIndex, String sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
                    }

        [Route("Movies/Released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        */
        

    }

}