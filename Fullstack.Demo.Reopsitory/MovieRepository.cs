using Fullstack.Demo.Common.Repository;
using Fullstack.Demo.Dal;
using Fullstack.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullstack.Demo.Reopsitory
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            using (var ctx = new MovieDbContext())
            {
                return ctx.Movies;
            }
        }

        public Movie GetById(int id)
        {
            using (var ctx = new MovieDbContext())
            {
                return ctx.Movies.Find(m => m.Id == id);
            }
        }
    }
}
