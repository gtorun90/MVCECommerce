using ECommerceApp.Dal.Abstract;
using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Dal.Concrete.EntityFrameWork
{
    public class EfCartDal:ICartDal
    {

        ECommerceAppDbContext _context = new ECommerceAppDbContext();
        Cart _cart = new Cart();
        public void Add(Product product, int quantity)
        {
            var cartLine = _cart.CartLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (cartLine == null)
            {
                _cart.CartLines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else {
                cartLine.Quantity += 1;
            }
        }

        public void Delete(Product product)
        {
            _cart.CartLines.RemoveAll(i=>i.Product.Id == product.Id);
        }
        public double Total()
        {
            return _cart.CartLines.Sum(i=>i.Product.Price*i.Quantity);
        }
        public void Clear()
        {
            _cart.CartLines.Clear();
        }        
        public Product Get(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.Id == productId);
        }        
        public Cart GetCarts()
        {
            return _cart;
        }
    }
}
