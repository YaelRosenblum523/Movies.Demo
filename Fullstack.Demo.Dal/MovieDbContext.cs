using Fullstack.Demo.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fullstack.Demo.Dal
{
    public class MovieDbContext : IDisposable
    {
        public List<Movie> Movies { get; set; }


        public MovieDbContext()
        {
            LoadJson();
        }

        void LoadJson()
        {
            using (StreamReader r = new StreamReader(Properties.Settings.Default.DbFileUrl))
            {
                string json = r.ReadToEnd();
                var obj = JsonConvert.DeserializeObject<MovieWrapper>(json);
                Movies = obj.Movies;
            }
        }

        public void Dispose()
        {
            this.Movies = new List<Movie>();
        }
    }
}
