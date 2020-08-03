using ECommerceApp.Bll.Abstract;
using ECommerceApp.Dal.Abstract;
using ECommerceApp.Entities;
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

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Get(int productId)
        {
            return _productDal.Get(p=>p.Id == productId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByIsHome()
        {
            return _productDal.GetAllByIsHome();
        }

        public List<Product> GetAllWithShortDescrition()
        {
            return _productDal.GetAllWithShortDescrition();
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _productDal.GetProductsByCategoryId(categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}

