using NewL.Entities.Concrete;
using NewL.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Data.Abstract
{
    public interface IProductRepository:IEntityRepository<Product>
    {
        
    }
}
