using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidify.Models;

namespace Vidify.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random , this action will get random movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Puss in Boots"};  
            return View(movie);                            //return corresponding view created for method
        }
    }
}