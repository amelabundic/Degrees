using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParfumeOnlineShop.Interfaces;
using ParfumeOnlineShop.Models;

namespace ParfumeOnlineShop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> Categories => _appDbContext.Category;
    }
}
