using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Dal.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        Category Get(int productId);
        void Add(Category category);
        void Delete(int categoryId);
        void Update(Category category);
    }
}
