using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParfumeOnlineShop.Interfaces;
using ParfumeOnlineShop.Models;

namespace ParfumeOnlineShop.Repositories
{
    public class ParfumeRepository : IParfumeRepository
    {
        private readonly AppDbContext _appDbContext;

        public ParfumeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Parfume> Parfumes
        {
            get
            {
                return _appDbContext.Parfume.Include(c => c.Category);
            }
        }

        public IEnumerable<Parfume> ParfumesOfTheMonth
        {
            get
            {
                return _appDbContext.Parfume.Include(c => c.Category).Where(p => p.IsParfumeOfTheMonth);
            }
        }

        public Parfume GetParfumeById(int parfumeId)
        {
            return _appDbContext.Parfume.FirstOrDefault(p => p.ParfumeId == parfumeId);
        }
    }
}
