using Fullstack.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullstack.Demo.Common.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie GetById(int id);
    }
}
