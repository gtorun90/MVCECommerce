using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Dal.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        List<Product> GetAllWithShortDescrition();
        List<Product> GetProductsByCategoryId(int categoryId);
        Product Get(int productId);
        void Add(Product product);
        void Delete(int productId);
        void Update(Product product);
    }
}
