using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie_JustinMeyer.Models
{
    public class Movie 
    {
        public int ID
        {
            get;
            set;
        }

        [StringLength(60, MinimumLength = 3)]
        public string Title
        {
            get;
            set;
        }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(50)]
        public string Director
        {
            get;
            set;
        }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate
        {
            get;
            set;
        }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), Required, StringLength(30)]
        public string Genre
        {
            get;
            set;
        }

        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price
        {
            get;
            set;
        }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(5)]
        public string Rating
        {
            get;
            set;
        }

        public double IMDB_Rating
        {
            get;
            set;
        }
       
    }
}
