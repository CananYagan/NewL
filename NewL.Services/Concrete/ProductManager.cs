using NewL.Data.Abstract;
using NewL.Entities.Dtos;
using NewL.Services.Abstract;
using NewL.Shared.Utilities.Results.Abstract;
using NewL.Shared.Utilities.Results.ComplexTypes;
using NewL.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Services.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitofWork _unitOfWork;

        public ProductManager(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Add(ProductAddDto productDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int productId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ProductDto>> Get(int productId)
        {
            var product = await _unitOfWork.Products.GetAsync(p=>p.Id==productId,p=>p.User,p=>p.Category);
            if (product!=null)
            {
                return new DataResult<ProductDto>(ResultStatus.Success, new ProductDto
                {
                    Product = product,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductDto>(ResultStatus.Error, "Böyle bir makale bulunamadı", null);
        }

        public async Task<IDataResult<ProductListDto>> GetAll()
        {
            var products=await _unitOfWork.Products.GetAllAsync(null,p=>p.User,p=>p.Category);
            if (products.Count>-1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error,"Ürünler bulunamadı",null);
        }

        public async Task<IDataResult<ProductListDto>> GetAllByCategory(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var products = await _unitOfWork.Products.GetAllAsync(p=>p.CategorId==categoryId && !p.IsActive && !p.IsDeleted,p=>p.User,p=>p.Category);
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products,
                    ResultStatus = ResultStatus.Success
                });
                return new DataResult<ProductListDto>(ResultStatus.Error, "Ürünler bulunamadı", null);
            }
            return new DataResult<ProductListDto>(ResultStatus.Error,"Böyle bir kategori bulunamadı",null);
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeleted()
        {
            var products = await _unitOfWork.Products.GetAllAsync(p=>!p.IsDeleted, p => p.User, p => p.Category);
            if (products.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Ürünler bulunamadı", null);
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeletedAndActive()
        {
            var products = await _unitOfWork.Products.GetAllAsync(p => !p.IsDeleted && !p.IsActive, p => p.User, p => p.Category);
            if (products.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, "Ürünler bulunamadı", null);
        }

        public Task<IResult> HardDelete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ProductUpdateDto productUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
