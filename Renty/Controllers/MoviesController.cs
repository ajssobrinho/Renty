using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Renty.Models;
using Renty.ViewModels;

namespace Renty.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie(){ Nome = "Shrek" };

            var clientes = new List<Cliente>
            {
                new Cliente {Nome = "Cliente número 1"},
                new Cliente {Nome = "Cliente número 2"}
            };

            var ViewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Clientes = clientes
            };

            return View(ViewModel);

            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, SortBy  ="name" } );

        }

        

    }
}