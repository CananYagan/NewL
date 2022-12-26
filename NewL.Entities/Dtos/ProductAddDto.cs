using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Entities.Dtos
{
    public class ProductAddDto
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden Küçük olmamalıdır")]
        public string Name { get; set; }

        [DisplayName("İçerik")]
        [MaxLength(ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(20, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır")]
        public string Content { get; set; }

        [DisplayName("Thumnail")]
        [MaxLength(250, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır")]
        public string Thumnail { get; set; }


        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString  = "{0:dd/MM/yyyy}")]
        public bool Date { get; set; }

        [DisplayName("Seo Yazar")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır")]
        public string SeoAuthor { get; set; }

        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(0, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır")]
        public string SeoDescription { get; set; }

        [DisplayName("Seo Etiketler")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden az olmamalıdır")]
        public string SeoTags { get; set; }

        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public int CategoryId { get; set; }

        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public bool isActive { get; set; }


        [DisplayName("Silinsin mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public bool isDeleted { get; set; }
    }
}
