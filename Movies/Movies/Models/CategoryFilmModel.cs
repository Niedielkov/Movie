using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Models;

namespace Movies.Models
{
    public class CategoryFilmModel
    {
        public List<CategoryModel> CategoryModels { get; set; }
        public PaginatedList<FilmModel> FilmModels { get; set; }
    }
}
