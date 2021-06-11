using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParfumeOnlineShop.Models;

namespace ParfumeOnlineShop.Interfaces
{
   public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
