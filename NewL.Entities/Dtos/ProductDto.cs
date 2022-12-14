using NewL.Entities.Concrete;
using NewL.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Entities.Dtos
{
    public class ProductDto : DtoGetBase
    {
        public Product Product { get; set; }
    }
}
