using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;

        public void CreateCategory(Category category)
        {
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            Category temp = _appDbContext.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (temp != null)
            {
                _appDbContext.Categories.Remove(temp);
                _appDbContext.SaveChanges();
            }
        }
    }
}
