using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullstack.Demo.Entities
{
    public class MovieWrapper
    {
        [JsonProperty("movies")]
        public List<Movie> Movies { get; set; }
    }
}
