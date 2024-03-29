﻿using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Dal.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<Product> GetAllByIsHome();
        List<Product> GetAllWithShortDescrition();
        List<Product> GetProductsByCategoryId(int categoryId);
    }
}
