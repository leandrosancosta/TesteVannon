using Business.Business;
using Core.Model;
using Service.Areas.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Service.Areas.App.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesBusiness mb;

        public MoviesController()
        {
            mb = new MoviesBusiness();
        }

        // GET: App/Movies
        public ActionResult Index(string message)
        {
            var movies = mb.GetMovies();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MovieViewModel movie)
        {
            try
            {
                Movie model = new Movie()
                {
                    Name = movie.Name,
                    Gender = movie.Gender,
                    Quantity = movie.Quantity,
                    Released = movie.Released,
                    Stats = movie.Stats,
                    ParentalGuide = movie.ParentalGuide,
                    Resume = movie.Resume
                };

                var ret = mb.AddMovie(model);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        
        public ActionResult Edit(int? id)
        {
            if(id == 0 || id == null)
            {
                return RedirectToAction("Index", 0);
            }

            var movie = mb.GetMovieById(id);

            if(movie == null)
                return RedirectToAction("Index", 0);

            return View(movie);
        }

    }
}