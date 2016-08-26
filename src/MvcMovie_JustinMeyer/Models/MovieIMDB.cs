using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie_JustinMeyer.Models
{
    public class MovieIMDB
    {
        public List<Movie> movies;
        public SelectList IMDB_Rating;
        public string movieGenre
        {
            get;
            set;
        }
    }
}