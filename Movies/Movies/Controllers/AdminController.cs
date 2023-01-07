using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Data;
using Movies.Models;
using Movies.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class AdminController : Controller
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminController(IFilmRepository filmRepository, IWebHostEnvironment webHostEnvironment)
        {
            _filmRepository = filmRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        [Authorize(Roles = "admin")]
        public async Task<ViewResult> AdminPage(string title, string category, int pageIndex = 1)
        {
            var films = new List<FilmModel>();

            if (title != "" && title != null)
            {
                films = await _filmRepository.GetFilmsBySearch(title);
                ViewBag.Search = title;
            }
            else if (category != "Select category" && category != null)
            {
                films = await _filmRepository.GetFilmsByCategory(category);
                ViewBag.Category = category;
            }
            else
            {
                films = await _filmRepository.GetAllFilms();
            }

            CategoryFilmModel model = new CategoryFilmModel();
            model.FilmModels = PaginatedList<FilmModel>.PaginatedListOfFilms(films, pageIndex, 10);

            return View(model);
        }

        [Authorize(Roles = "admin")]
        public ViewResult CreateFilm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFilm(FilmModel filmModel)
        {
            if (ModelState.IsValid)
            {
                if(filmModel.CoverImage != null)
                {
                    string folder = "films/cover/";
                    filmModel.CoverImageUrl = await UploadFile(folder, filmModel.CoverImage);
                }

                var id = await _filmRepository.AddFilm(filmModel);

                if (id > 0)
                {
                    return RedirectToAction("AdminPage", "Admin");
                }
            }

            return View();
        }

        private async Task<string> UploadFile(string folderPath, IFormFile file)
        {
            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }

        [Authorize(Roles = "admin")]
        public async Task<ViewResult> EditFilm(int id)
        {
            var model = await _filmRepository.GetFilmById(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditFilm(FilmModel filmModel)
        {
            if (ModelState.IsValid)
            {
                if (filmModel.CoverImage != null)
                {
                    string folder = "films/cover/";
                    filmModel.CoverImageUrl = await UploadFile(folder, filmModel.CoverImage);
                }

                await _filmRepository.EditFilm(filmModel);
                return RedirectToAction("AdminPage", "Admin");
            }

            return View();
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteFilm(int id)
        {
            await _filmRepository.DeleteFilm(id);
            return RedirectToAction("AdminPage", "Admin");
        }
    }
}
