using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Entities
{
    public class Category
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Ad Alanını Boş Bırakmayınız!"),MaxLength(30,ErrorMessage = "En Fazla 30 Karakter Girebilirsiniz!")]
        [Display(Name = "Kategori Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama Alanını Boş Bırakmayınız!"), MaxLength(50, ErrorMessage = "En Fazla 50 Karakter Girebilirsiniz!")]
        [Display(Name = "Kategori Açıklaması")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
