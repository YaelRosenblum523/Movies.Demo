using Fullstack.Demo.Common.UoW;
using Fullstack.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullstack.Demo.Bl
{
    public class MovieBL
    {
        IMovieManagementUoW _db;
        public MovieBL(IMovieManagementUoW db)
        {
            _db = db;
        }

        public List<Movie> GetAll()
        {
            return _db.Movies.GetAll();
        }

        public Movie GetById(int id)
        {
            return _db.Movies.GetById(id);
        }

    }
}
