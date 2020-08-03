using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Bll.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category Get(int categoryId);

        void Add(Category category);

        void Update(Category category);

        void Delete(Category category);
    }
}
