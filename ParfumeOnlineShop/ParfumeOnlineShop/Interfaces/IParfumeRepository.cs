using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParfumeOnlineShop.Models;

namespace ParfumeOnlineShop.Interfaces
{
   public interface IParfumeRepository
    {
        IEnumerable<Parfume> Parfumes { get; }
        IEnumerable<Parfume> ParfumesOfTheMonth { get; }

        Parfume GetParfumeById(int parfumeId);
    }
}
