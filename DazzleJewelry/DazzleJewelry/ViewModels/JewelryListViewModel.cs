using DazzleJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.ViewModels
{
    public class JewelryListViewModel
    {
        public IEnumerable<Jewelry> Jewelries { get; set; }
        public string CurrentCategory { get; set; }
    }
}
