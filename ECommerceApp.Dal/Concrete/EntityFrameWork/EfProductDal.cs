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
    public class EfProductDal:IProductDal
    {
        ECommerceAppDbContext  _context = new ECommerceAppDbContext();
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(p => p.Id == productId));
            _context.SaveChanges();
        }

        public Product Get(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.Id == productId);
        }

        public List<Product> GetAll()
        {
            return _context.Products.Include(p=>p.Category).ToList();                            
        }         
        public List<Product> GetAllByIsHome()
        {
            return _context.Products.Where(p => p.IsHome).Select(p => new { p.Id, p.Name, p.Description, p.Image, p.Price, p.Stock, p.IsHome, p.IsApproved, p.CategoryId }).ToList()
                                                .Select(p => new Product() { Id = p.Id, Name = p.Name.Length > 70 ? p.Name.Substring(0, 70) + "..." : p.Name, Description = p.Description.Length > 50 ? p.Description.Substring(0, 50) + "..." : p.Description, Image = p.Image, Price = p.Price, Stock = p.Stock, IsHome = p.IsHome, IsApproved = p.IsApproved, CategoryId = p.CategoryId }).ToList(); ;
        }           
        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Products.Where(p => p.CategoryId == categoryId).Select(p => new { p.Id, p.Name, p.Description, p.Image, p.Price, p.Stock, p.IsHome, p.IsApproved, p.CategoryId }).ToList()
                                                .Select(p => new Product() { Id = p.Id, Name = p.Name.Length > 70 ? p.Name.Substring(0, 70) + "..." : p.Name, Description = p.Description.Length > 50 ? p.Description.Substring(0, 50) + "..." : p.Description, Image = p.Image, Price = p.Price, Stock = p.Stock, IsHome = p.IsHome, IsApproved = p.IsApproved, CategoryId = p.CategoryId }).ToList();
        }            
        public List<Product> GetAllWithShortDescrition()
        {
            return _context.Products.Where(p => p.IsApproved && p.IsHome).Select(p => new { p.Id, p.Name,p.Description,p.Image,p.Price,p.Stock,p.IsHome,p.IsApproved,p.CategoryId}).ToList()
                                                .Select(p => new Product() { Id = p.Id, Name = p.Name.Length > 70 ? p.Name.Substring(0, 70) + "..." : p.Name, Description = p.Description.Length > 50 ? p.Description.Substring(0, 50) + "..." : p.Description, Image = p.Image, Price = p.Price,Stock = p.Stock, IsHome = p.IsHome, IsApproved = p.IsApproved, CategoryId = p.CategoryId }).ToList();
        }        

        public void Update(Product product)
        {
            Product productToUpdate = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            productToUpdate.Name = product.Name;
            productToUpdate.Description= product.Description;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.Image = product.Image;
            productToUpdate.Price = product.Price;
            productToUpdate.Stock = product.Stock;
            productToUpdate.IsHome = product.IsHome;
            productToUpdate.IsApproved = product.IsApproved;
            _context.SaveChanges(); 
        }
    }
}
