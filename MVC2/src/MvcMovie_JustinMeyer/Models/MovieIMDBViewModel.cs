using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie_JustinMeyer.Models
{
    public class MovieIMDBViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public double IMDB_Rating
        {
            get;
            set;
        }
    }
}
