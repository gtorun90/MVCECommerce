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
    public class CartManager:ICartService
    {
        private ICartDal _cartDal;
        public CartManager(ICartDal cartDal)
        {
           _cartDal = cartDal;
        }
        public void Add(Product product,int quantity)
        {
            _cartDal.Add(product,quantity);
        }

        public void Clear()
        {
            _cartDal.Clear();
        }

        public void Delete(Product product)
        {
            _cartDal.Delete(product);
        }

        public Product Get(int productId)
        {
            return _cartDal.Get(productId);
        }

        public Cart GetCarts()
        {
            return _cartDal.GetCarts();
        }

        public double Total()
        {
            return _cartDal.Total();
        }

    }
}
