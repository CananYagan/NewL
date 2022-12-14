﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0}{1} karakterden büyük olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden az olmamalıdır")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0}{1} karakterden büyük olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden az olmamalıdır")]
        public string Description { get; set; }

        [DisplayName("Kategori Özel Note Alanı")]
        [MaxLength(500, ErrorMessage = "{0}{1} karakterden büyük olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden az olmamalıdır")]
        public string Note { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public bool isActive { get; set; }

        [DisplayName("Silindi Mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        public bool isDeleted { get; set; }
    }
}

