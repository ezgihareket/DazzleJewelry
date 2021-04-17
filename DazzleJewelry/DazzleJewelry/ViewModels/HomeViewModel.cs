using DazzleJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Jewelry> JewelryOnSale { get; set; }
    }
}
