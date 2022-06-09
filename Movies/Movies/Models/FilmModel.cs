using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class FilmModel
    {
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the title of your film")]
        public string Title { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the producer name")]
        public string Producer { get; set; }

        [StringLength(150, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter the description of your film")]
        public string Description { get; set; }

        [Required]
        public DateTime Year { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please choose the country")]
        public int CountryId { get; set; }
        public string Country { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please choose the category")]
        public int CategoryId { get; set; }
        public string Category { get; set; }

        [Display(Name = "Cover image")]
        [Required]
        public IFormFile CoverImage { get; set; }
        public string CoverImageUrl { get; set; }

        [Display(Name = "Film link")]
        [Required(ErrorMessage = "Please enter the film url")]
        public string FilmLink { get; set; }
    }
}
