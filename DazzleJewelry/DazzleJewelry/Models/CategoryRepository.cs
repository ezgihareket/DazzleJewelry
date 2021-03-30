using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Küpe" },
            new Category { CategoryId = 2, CategoryName = "Yüzük" },
            new Category { CategoryId = 3, CategoryName = "Kolye" }
        };
    }
}
