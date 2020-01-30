﻿using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Interfaces
{
    public interface ICartService
    {
        void Add(Product product,int quantity);
        void Delete(Product product);
        void Clear();
        double Total();
        Product Get(int productId);
        Cart GetCarts();
    }
}
