﻿using Core.Model;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL
{
    public class MovieDAL : DefaultContext
    {
        public IQueryable<Movie> GetMoviesList()
        {
            return _context.Movies;
        }

        public Movie Add(Movie model)
        {
            _context.Movies.Add(model);
            _context.SaveChanges();

            return model;
        }

        public Movie GetMovieById(int? id)
        {
            if(id == 0 || id == null)
                return null;

            return _context.Movies.Where(m => m.ID == id).FirstOrDefault();
        }
        
        public Movie UpdateMovie(Movie model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
            return model;
        }

        public bool Delete(int id)
        {
            try
            {
                Movie movie = GetMovieById(id);
                _context.Movies.Remove(movie);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
