using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public interface IJewelryRepository
    {
        IEnumerable<Jewelry> GetAllJewelry { get; }
        IEnumerable<Jewelry> GetJewelryOnSale { get; }
        Jewelry GetJewelryById(int jewelryId);
    }
}
