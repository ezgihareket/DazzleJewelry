using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public class JewelryRepository : IJewelryRepository
    {
        private readonly AppDbContext _appDbContext;
        public JewelryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Jewelry> GetAllJewelry
        {
            get
            {
                return _appDbContext.Jewelries.Include(c => c.Category);
            }
        }

        public IEnumerable<Jewelry> GetJewelryOnSale
        {
            get
            {
                return _appDbContext.Jewelries.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Jewelry GetJewelryById(int jewelryId)
        {
            return _appDbContext.Jewelries.FirstOrDefault(c => c.JewelryId == jewelryId);
        }
    }
}
