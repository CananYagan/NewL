using AutoMapper;
using NewL.Data.Abstract;
using NewL.Entities.Concrete;
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
        private readonly IMapper _mapper;

        public ProductManager(IUnitofWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Add(ProductAddDto productAddDto, string createdByName)
        {
            var product = _mapper.Map<Product>(productAddDto);
            product.CreatedByName = createdByName;
            product.ModifiedByName = createdByName;
            product.UserId = 1;
            await _unitOfWork.Products.AddAsync(product).ContinueWith(t => _unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success,$"{productAddDto.Name} ürün başarıyla eklenmiştir");

        }

        public async Task<IResult> Delete(int productId, string modifiedByName)
        {
            var result= await _unitOfWork.Products.AnyAsync(p=>p.Id==productId);
            if (result)
            {
                var product = await _unitOfWork.Products.GetAsync(p => p.Id == productId);
                product.IsDeleted=true;
                product.ModifiedByName = modifiedByName;
                product.ModifiedDate=DateTime.Now;
                await _unitOfWork.Products.UpdateAsync(product).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success,$"{product.Name} ürünü silinmiştir");
            }
            return new Result(ResultStatus.Error, "Böyle bir ürün bulunamadı");
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
            return new DataResult<ProductDto>(ResultStatus.Error, "Böyle bir ürün bulunamadı", null);
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

        public async Task<IResult> HardDelete(int productId)
        {
            var result = await _unitOfWork.Products.AnyAsync(p => p.Id == productId);
            if (result)
            {
                var product = await _unitOfWork.Products.GetAsync(p => p.Id == productId);
                await _unitOfWork.Products.DeleteAsync(product).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{product.Name} ürünü veritabanından silinmiştir");
            }
            return new Result(ResultStatus.Error, "Böyle bir ürün bulunamadı");
        }

        public async Task<IResult> Update(ProductUpdateDto productUpdateDto, string modifiedByName)
        {
            var product=_mapper.Map<Product>(productUpdateDto);
            product.ModifiedByName = modifiedByName;
            await _unitOfWork.Products.UpdateAsync(product).ContinueWith(t=>_unitOfWork.SaveAsync());
            return new Result(ResultStatus.Success,$"{productUpdateDto.Name} ürün başarıyla güncellenmiştir.");
        }
    }
}
