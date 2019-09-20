using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fullstack.Demo.Entities
{    
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("plot")]
        public string Plot { get; set; }
        [JsonProperty("posterUrl")]
        public string PosterUrl { get; set; }
        [JsonProperty("runtime")]
        public short Runtime { get; set; }
        [JsonProperty("year")]
        public short Year { get; set; }
        [JsonProperty("actors")]
        public string Actors { get; set; }
        [JsonProperty("director")]
        public string Director { get; set; }
    }
}
