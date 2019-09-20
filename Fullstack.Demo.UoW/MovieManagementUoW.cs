using Fullstack.Demo.Common.Repository;
using Fullstack.Demo.Common.UoW;
using Fullstack.Demo.Reopsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullstack.Demo.UoW
{
    public class MovieManagementUoW : IMovieManagementUoW
    {
        private Lazy<IMovieRepository> _movies;
        public IMovieRepository Movies
        {
            get { return _movies.Value; }
        }

        public MovieManagementUoW()
        {
            _movies = new Lazy<IMovieRepository>(() => new MovieRepository(), true);
        }
    }
}
