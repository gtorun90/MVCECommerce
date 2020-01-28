using ECommerceApp.Dal.Abstract;
using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Dal.Concrete.EntityFrameWork
{
    public class EfCategoryDal:ICategoryDal
    {
        ECommerceAppDbContext _context = new ECommerceAppDbContext();
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int categoryId)
        {
            _context.Categories.Remove(_context.Categories.FirstOrDefault(c => c.Id == categoryId));
            _context.SaveChanges();
        }

        public Category Get(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
            categoryToUpdate.Name = category.Name;
            categoryToUpdate.Description = category.Description;
            _context.SaveChanges();
        }
    }
}
