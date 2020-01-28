using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByIsHome();
        
        List<Product> GetAllWithShortDescrition();
        List<Product> GetProductsByCategoryId(int categoryId);
        Product Get(int productId);
        void Add(Product product);

        void Update(Product product);

        void Delete(int productId);
    }
}
