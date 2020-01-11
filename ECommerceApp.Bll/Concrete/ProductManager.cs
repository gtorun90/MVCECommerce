using ECommerceApp.Dal.Abstract;
using ECommerceApp.Entities;
using ECommerceApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Bll.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productDal.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _productDal.GetProductsByCategoryId(categoryId);
        }
        public List<Product> GetAllWithShortDescrition()
        {
            return _productDal.GetAllWithShortDescrition();
        }        

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}

