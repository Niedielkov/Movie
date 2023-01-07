using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private MoviesContext _context = null;

        public CountryRepository(MoviesContext context)
        {
            _context = context;
        }

        public async Task<List<CountryModel>> GetAllCountries()
        {
            return await _context.Countries.Select(country => new CountryModel()
            {
                Id = country.Id,
                Name = country.Name
            }).ToListAsync();
        }
    }
}