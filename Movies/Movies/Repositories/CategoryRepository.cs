using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private MoviesContext _context = null;

        public CategoryRepository(MoviesContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryModel>> GetAllCategories()
        {
            return await _context.Categories.Select(category => new CategoryModel()
            {
                Id = category.Id,
                Name = category.Name
            }).ToListAsync();
        }
    }
}
