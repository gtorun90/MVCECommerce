using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description  { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsHome{ get; set; }
        public bool IsApproved { get; set; }
        public int CategoryId { get; set; }  //int? nullable anlamında
        public Category Categories { get; set; }
    }
}
