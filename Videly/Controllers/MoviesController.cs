using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videly.Models;
using Videly.RandomMovieViewModel;

namespace Videly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shark" };

            var Customer = new List<Customer>
            {
                 new Customer{Name="Customer 1" },
                 new Customer {Name ="Customer 2" }

            };
            var viewModel = new RandomMovie
            {
                Movie = movie,
                Customers = Customer
            };

            return View(viewModel);
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { pages = 1, sortby = "name" });
        }
        public ActionResult Customer()


        {
            var movie = new Movie() { Name = "Shark" };

            var Customer = new List<Customer>
            {
                 new Customer{Name="Customer 1" },
                 new Customer {Name ="Customer 2" },
                  new Customer{Name="Customer 3" },
                 new Customer {Name ="Customer 4" },
                  new Customer{Name="Customer 5" },
                 new Customer {Name ="Customer 6" },
                  new Customer{Name="Customer 7" },
                 new Customer {Name ="Customer 8" }
            };
            var viewModel = new RandomMovie

            {
                Movie = movie,
                Customers = Customer
            };

            return View(viewModel);
        }

        public ActionResult Details(string name)
        {

            return Content(String.Format("Customer Name=" + name));
        }

        /// <summary>
        /// Below method takes id as paramater.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionResult Edit(int Id)
        {
            return Content("Id=" + Id);
        }

        public ActionResult PageIndex(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (!String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content(String.Format("pageIndex={0} and sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/Abc/{year}/{month}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }


}