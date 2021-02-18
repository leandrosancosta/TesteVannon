using Core.Model;
using Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business
{
    public class MoviesBusiness
    {
        public MovieDAL dal;

        public MoviesBusiness()
        {
            dal = new MovieDAL();
        }

        public IQueryable<Movie> GetMovies()
        {
            return dal.GetMoviesList();
        }

        public Movie AddMovie(Movie model)
        {
            return dal.Add(model);
        }
        
        public Movie Edit(Movie model)
        {
            return dal.UpdateMovie(model);
        }

        public Movie GetMovieById(int? id)
        {
            if (id == 0 || id == null)
                return null;

            return dal.GetMovieById(id);

        }

    }
}
