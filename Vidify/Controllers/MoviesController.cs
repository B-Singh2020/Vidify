﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidify.Models;
using Vidify.ViewModels;

namespace Vidify.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context { get; set; }

        public MoviesController()  //creates dbcontext
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)  //disposes dbcontext
        {
            _context.Dispose();
        }

        public ViewResult Index()  // returns movies list
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");
            
                return View("ReadOnlyList");
        }
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres,

            };
            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)  //method called to get existing movie from db to edit
        {
            var movie = _context.Movies.SingleOrDefault(c  => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }  

        public ActionResult Details(int id)  //returns view of movies or not found
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)        //method to save changes or add movie to db 
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
         else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }

}