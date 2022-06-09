using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Repositories
{
    public interface IFilmRepository
    {
        Task<List<FilmModel>> GetAllFilms();
        Task<int> AddFilm(FilmModel filmModel);
        Task<FilmModel> GetFilmById(int id);
        Task EditFilm(FilmModel filmModel);
        Task DeleteFilm(int id);
        Task<List<FilmModel>> GetFilmsByCategory(string category);
        Task<List<FilmModel>> GetFilmsBySearch(string search);
    }
}
