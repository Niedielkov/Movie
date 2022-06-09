using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public int CountryId { get; set; }
        public int CategoryId { get; set; }
        public string CoverImageUrl { get; set; }
        public string FilmLink { get; set; }
        public Country Country { get; set; }
        public Category Category { get; set; }
    }
}
