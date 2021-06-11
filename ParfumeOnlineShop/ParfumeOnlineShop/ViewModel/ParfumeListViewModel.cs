using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParfumeOnlineShop.Models;

namespace ParfumeOnlineShop.ViewModel
{
    public class ParfumeListViewModel
    {
        public IEnumerable<Parfume> Parfumes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
