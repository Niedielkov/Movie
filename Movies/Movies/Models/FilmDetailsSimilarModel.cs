using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class FilmDetailsSimilarModel
    {
        public FilmModel FilmModel { get; set; }
        public List<FilmModel> FilmModels { get; set; }
    }
}
