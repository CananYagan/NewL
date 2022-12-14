using NewL.Entities.Concrete;
using NewL.Entities.Dtos;
using NewL.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Services.Abstract
{
    public interface IProductService
    {
        Task<IDataResult<ProductDto>> Get(int productId);
        Task<IDataResult<ProductListDto>> GetAll();
        Task<IDataResult<ProductListDto>> GetAllByNonDeleted();
        Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActive();
        Task<IDataResult<ProductListDto>> GetAllByCategory(int categoryId);
        Task<IResult> Add(ProductAddDto productDto, string createdByName);
        Task<IResult> Update(ProductUpdateDto productUpdateDto, string modifiedByName);
        Task<IResult> Delete(int productId, string modifiedByName);
        Task<IResult> HardDelete(int productId);

    }
}
