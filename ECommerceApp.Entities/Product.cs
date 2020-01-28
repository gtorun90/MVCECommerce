using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün Adı Alanını Boş Bırakmayınız!"),MaxLength(200,ErrorMessage = "En Fazla 200 Karakter Girebilirsiniz!")]
        [Display(Name = "Ürün Adı")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Açıklama Alanını Boş Bırakmayınız!"),MaxLength(500,ErrorMessage ="En Fazla 500 Karakter Girebilirsiniz!")]
        [Display(Name = "Ürün Açıklaması")]
        public string Description  { get; set; }

        [Required(ErrorMessage = "Ürün Fotoğrafı Alanını Boş Bırakmayınız!")]
        [Display(Name = "Ürün Fotoğrafı")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Fiyat Alanını Boş Bırakmayınız!")]
        [Display(Name = "Fiyat")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Stok Alanını Boş Bırakmayınız!")]
        [Display(Name = "Stok")]
        public int Stock { get; set; }

        [Required]
        [Display(Name = "Ana Sayfa")]
        public bool IsHome{ get; set; }

        [Required]
        [Display(Name = "Onaylı")]
        public bool IsApproved { get; set; }

        [Required(ErrorMessage = "Kategori Alanını Boş Bırakmayınız!")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }  //int? nullable anlamında
        public Category Category { get; set; }
    }
}
