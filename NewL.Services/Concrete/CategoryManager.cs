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
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public CategoryManager(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            var category = _mapper.Map<Category>(categoryAddDto);
            category.CreatedByName = createdByName;
            category.ModifiedByName = createdByName;
            await _unitofWork.Categories.AddAsync(category).ContinueWith(t=>_unitofWork.SaveAsync());
            return new Result(ResultStatus.Success,$"{categoryAddDto.Name} adlı kategori başarıyla eklenmiştir.");
        }

        public async Task<IResult> Delete(int categoryId, string modifiedByName)
        {
            var category = await _unitofWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                category.Name = category.Name;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                await _unitofWork.Categories.UpdateAsync(category).ContinueWith(t => _unitofWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı");
        }

        public async Task<IDataResult<CategoryDto>> Get(int categoryId)
        {
            var category = await _unitofWork.Categories.GetAsync(c=>c.Id==categoryId,c=>c.Products);
            if (category!=null)
            {
                return new DataResult<CategoryDto>(ResultStatus.Success,new CategoryDto
                {
                    Category=category,
                    ResultStatus=ResultStatus.Success
                } );
            }
            return new DataResult<CategoryDto>(ResultStatus.Error, "Böyle bir kategori bulumadı.",null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
            var categories=await _unitofWork.Categories.GetAllAsync(null,c=>c.Products);
            if (categories.Count>-1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success,new CategoryListDto
                {
                    Categories=categories,
                    ResultStatus = ResultStatus.Success

                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulumadı.", null);
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleted()
        {
            var categories = await _unitofWork.Categories.GetAllAsync(c=>!c.IsDeleted,c=>c.Products);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto> (ResultStatus.Success, new CategoryListDto
                {
                    Categories=categories,
                    ResultStatus=ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto> (ResultStatus.Error, "Hiç bir kategori bulumadı.", null);
        }

        public async  Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive()
        {
            var categories = await _unitofWork.Categories.GetAllAsync(c => !c.IsDeleted&&c.IsActive, c => c.Products);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, "Hiç bir kategori bulumadı.", null);
        }

        public async Task<IResult> HardDelete(int categoryId)
        {
            var category = await _unitofWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                await _unitofWork.Categories.UpdateAsync(category).ContinueWith(t => _unitofWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{category.Name} adlı kategori başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı");
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var category = _mapper.Map<Category>(categoryUpdateDto);
            category.ModifiedByName = modifiedByName;
            await _unitofWork.Categories.UpdateAsync(category).ContinueWith(t=>_unitofWork.SaveAsync());
            return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı kategori başarıyla günlenmiştir.");
            
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı");
        }
    }
}
