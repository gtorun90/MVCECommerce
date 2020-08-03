using ECommerceApp.Dal.Abstract;
using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Dal.Concrete.EntityFrameWork
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,ECommerceAppDbContext>,ICategoryDal
    {
       
    }
}
