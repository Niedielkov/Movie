using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Movies.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class FilmsController : Controller
    {
        private readonly IFilmRepository _filmRepository;
        private readonly ICategoryRepository _categoryRepository;

        public FilmsController(IFilmRepository filmRepository, ICategoryRepository categoryRepository)
        {
            _filmRepository = filmRepository;
            _categoryRepository = categoryRepository;
        }

        [Authorize]
        public async Task<ViewResult> FilmsPage(string category, string search, int pageIndex = 1)
        {
            var films = new List<FilmModel>();

            if (search != "" && search != null)
            {
                films = await _filmRepository.GetFilmsBySearch(search);
                ViewBag.Search = search;
            }
            else
            {
                if (category == null)
                {
                    films = await _filmRepository.GetAllFilms();
                }
                else
                {
                    films = await _filmRepository.GetFilmsByCategory(category);
                    ViewBag.Category = category;
                }
            }

            var categories = await _categoryRepository.GetAllCategories();

            CategoryFilmModel model = new CategoryFilmModel();
            model.FilmModels = PaginatedList<FilmModel>.PaginatedListOfFilms(films, pageIndex, 6);
            model.CategoryModels = categories;

            return View(model);
        }

        [Authorize]
        public async Task<ViewResult> FilmDetails(int id)
        {
            FilmDetailsSimilarModel model = new FilmDetailsSimilarModel();
            model.FilmModel = await _filmRepository.GetFilmById(id);
            model.FilmModels = await _filmRepository.GetFilmsByCategory(model.FilmModel.Category);

            foreach(var film in model.FilmModels)
            {
                if (film.Title.Equals(model.FilmModel.Title) && film.CoverImageUrl.Equals(model.FilmModel.CoverImageUrl))
                {
                    model.FilmModels.Remove(film);
                    return View(model);
                }
            }

            return View(model);
        }
    }
}
