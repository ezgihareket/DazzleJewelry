using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }

        void CreateCategory(Category category);

        void DeleteCategory(int id);
    }
}
