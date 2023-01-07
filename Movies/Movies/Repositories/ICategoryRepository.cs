﻿using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetAllCategories();
    }
}
