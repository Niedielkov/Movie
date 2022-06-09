using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies.Data;
using Microsoft.EntityFrameworkCore;

namespace Movies.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private MoviesContext _context = null;

        public FilmRepository(MoviesContext context)
        {
            _context = context;
        }

        public async Task<List<FilmModel>> GetAllFilms()
        {
            return await _context.Films.Select(film => new FilmModel()
            {
                Id = film.Id,
                Title = film.Title,
                Producer = film.Producer,
                Description = film.Description,
                Year = film.Year,
                CountryId = film.CountryId,
                Country = film.Country.Name,
                CategoryId = film.CategoryId,
                Category = film.Category.Name,
                CoverImageUrl = film.CoverImageUrl,
                FilmLink = film.FilmLink
            }).ToListAsync();
        }

        public async Task<int> AddFilm(FilmModel filmModel)
        {
            var newFilm = new Film
            {
                Title = filmModel.Title,
                Producer = filmModel.Producer,
                Description = filmModel.Description,
                Year = filmModel.Year.Date,
                CountryId = filmModel.CountryId,
                CategoryId = filmModel.CategoryId,
                CoverImageUrl = filmModel.CoverImageUrl,
                FilmLink = filmModel.FilmLink
            };

            await _context.Films.AddAsync(newFilm);
            await _context.SaveChangesAsync();

            return newFilm.Id;
        }

        public async Task DeleteFilm(int id)
        {
            var film = await _context.Films.FindAsync(id);
            _context.Films.Remove(film);
            await _context.SaveChangesAsync();
        }

        public async Task<FilmModel> GetFilmById(int id)
        {
            return await _context.Films.Where(x => x.Id == id).Select(film => new FilmModel
            {
                Id = film.Id,
                Title = film.Title,
                Producer = film.Producer,
                Description = film.Description,
                Year = film.Year,
                CountryId = film.CountryId,
                Country = film.Country.Name,
                CategoryId = film.CategoryId,
                Category = film.Category.Name,
                CoverImageUrl = film.CoverImageUrl,
                FilmLink = film.FilmLink
            }).FirstOrDefaultAsync();
        }

        public async Task EditFilm(FilmModel filmModel)
        {
            var film = new Film
            {
                Id = filmModel.Id,
                Title = filmModel.Title,
                Producer = filmModel.Producer,
                Description = filmModel.Description,
                Year = filmModel.Year.Date,
                CountryId = filmModel.CountryId,
                CategoryId = filmModel.CategoryId,
                CoverImageUrl = filmModel.CoverImageUrl,
                FilmLink = filmModel.FilmLink
            };

            _context.Update(film);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FilmModel>> GetFilmsByCategory(string category)
        {
            return await _context.Films.Where(x => x.Category.Name.Equals(category)).Select(film => new FilmModel
            {
                Id = film.Id,
                Title = film.Title,
                Producer = film.Producer,
                Description = film.Description,
                Year = film.Year,
                CountryId = film.CountryId,
                Country = film.Country.Name,
                CategoryId = film.CategoryId,
                Category = film.Category.Name,
                CoverImageUrl = film.CoverImageUrl,
                FilmLink = film.FilmLink
            }).ToListAsync();
        }

        public async Task<List<FilmModel>> GetFilmsBySearch(string search)
        {
            return await _context.Films.Where(x => x.Title.Contains(search)).Select(film => new FilmModel
            {
                Id = film.Id,
                Title = film.Title,
                Producer = film.Producer,
                Description = film.Description,
                Year = film.Year,
                CountryId = film.CountryId,
                Country = film.Country.Name,
                CategoryId = film.CategoryId,
                Category = film.Category.Name,
                CoverImageUrl = film.CoverImageUrl,
                FilmLink = film.FilmLink
            }).ToListAsync();
        }
    }
}
