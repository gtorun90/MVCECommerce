using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Entities
{
    public class Cart
    {
        private List<CartLine> _cartLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get
            {
                return _cartLines;
            }
        }
        public void AddToCart(Product product, int quantity)
        {
            var cartLine = _cartLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (cartLine == null)
            {
                _cartLines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                cartLine.Quantity += 1;
            }
        }

        public void RemoveFromCart(Product product)
        {
            _cartLines.RemoveAll(i => i.Product.Id == product.Id);
        }
        public double Total()
        {
            return _cartLines.Sum(i => i.Product.Price * i.Quantity);
        }
        public void Clear()
        {
            _cartLines.Clear();
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
