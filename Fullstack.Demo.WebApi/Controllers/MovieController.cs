using Fullstack.Demo.Bl;
using Fullstack.Demo.Common.UoW;
using Fullstack.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Fullstack.Demo.WebApi.Controllers
{
    public class MovieController : ApiController
    {
        MovieBL _bl;

        public MovieController(IMovieManagementUoW db)
        {
            _bl = new MovieBL(db);
        }



        // GET: api/Movie
        [HttpGet]
        [Route("api/movie")]
        [ResponseType(typeof(List<Movie>))]
        public IHttpActionResult Get()
        {
            return Ok(_bl.GetAll());
        }

        // GET: api/Movie/5
        [HttpGet]
        [Route("api/movie/{id}")]
        [ResponseType(typeof(Movie))]
        public IHttpActionResult Get(int id)
        {
            return Ok(_bl.GetById(id));
        }


        // GET: api/Movie/5
        [HttpGet]
        [Route("api/movie/test")]
        [ResponseType(typeof(void))]
        public IHttpActionResult Test()
        {
            throw new Exception("ha ha");
            return Ok();
        }

    }
}
