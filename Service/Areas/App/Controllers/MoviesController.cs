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
        public ActionResult Index()
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
            if (id == 0 || id == null)
            {
                return RedirectToAction("Index");
            }

            var model = mb.GetMovieById(id);

            if (model == null)
                return RedirectToAction("Index");

            MovieViewModel movie = new MovieViewModel()
            {
                ID = model.ID,
                Name = model.Name,
                Gender = model.Gender,
                Quantity = model.Quantity,
                Released = model.Released,
                Stats = model.Stats,
                ParentalGuide = model.ParentalGuide,
                Resume = model.Resume
            };

            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(MovieViewModel movie)
        {
            try
            {
                Movie model = new Movie()
                {
                    ID = movie.ID,
                    Name = movie.Name,
                    Gender = movie.Gender,
                    Quantity = movie.Quantity,
                    Released = movie.Released,
                    Stats = movie.Stats,
                    ParentalGuide = movie.ParentalGuide,
                    Resume = movie.Resume
                };

                var ret = mb.Edit(model);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public bool Delete()
        {
            try
            {
                //bool ret = mb.Delete((int)id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}