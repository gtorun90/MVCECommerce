using ECommerceApp.Dal.Abstract;
using ECommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Dal.Concrete.EntityFrameWork
{
    public class EfProductDal:EfEntityRepositoryBase<Product,ECommerceAppDbContext>,IProductDal
    {       
        public List<Product> GetAllByIsHome()
        {
            using (ECommerceAppDbContext context = new ECommerceAppDbContext())
            {
                return context.Products.Where(p => p.IsHome).Select(p => new { p.Id, p.Name, p.Description, p.Image, p.Price, p.Stock, p.IsHome, p.IsApproved, p.CategoryId }).ToList()
                                                .Select(p => new Product() { Id = p.Id, Name = p.Name.Length > 70 ? p.Name.Substring(0, 70) + "..." : p.Name, Description = p.Description.Length > 50 ? p.Description.Substring(0, 50) + "..." : p.Description, Image = p.Image, Price = p.Price, Stock = p.Stock, IsHome = p.IsHome, IsApproved = p.IsApproved, CategoryId = p.CategoryId }).ToList(); ;
            }
        }           
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            using (ECommerceAppDbContext context = new ECommerceAppDbContext())
            {
                return context.Products.Where(p => p.CategoryId == categoryId).Select(p => new { p.Id, p.Name, p.Description, p.Image, p.Price, p.Stock, p.IsHome, p.IsApproved, p.CategoryId }).ToList()
                                                       .Select(p => new Product() { Id = p.Id, Name = p.Name.Length > 70 ? p.Name.Substring(0, 70) + "..." : p.Name, Description = p.Description.Length > 50 ? p.Description.Substring(0, 50) + "..." : p.Description, Image = p.Image, Price = p.Price, Stock = p.Stock, IsHome = p.IsHome, IsApproved = p.IsApproved, CategoryId = p.CategoryId }).ToList();


            }
        }            
        public List<Product> GetAllWithShortDescrition()
        {
            using (ECommerceAppDbContext context = new ECommerceAppDbContext())
            {
                return context.Products.Where(p => p.IsApproved && p.IsHome).Select(p => new { p.Id, p.Name, p.Description, p.Image, p.Price, p.Stock, p.IsHome, p.IsApproved, p.CategoryId }).ToList()
                                                      .Select(p => new Product() { Id = p.Id, Name = p.Name.Length > 70 ? p.Name.Substring(0, 70) + "..." : p.Name, Description = p.Description.Length > 50 ? p.Description.Substring(0, 50) + "..." : p.Description, Image = p.Image, Price = p.Price, Stock = p.Stock, IsHome = p.IsHome, IsApproved = p.IsApproved, CategoryId = p.CategoryId }).ToList();


            }
        }  
    }
}
