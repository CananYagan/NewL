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
        public CategoryManager(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public async Task<IResult> Add(CategoryAddDto categoryDto, string createdByName)
        {
            await _unitofWork.Categories.AddAsync(new Category
            { 
                Name=categoryDto.Name,
                Description=categoryDto.Description,
                Note=categoryDto.Note,
                IsActive=categoryDto.isActive,
                CreatedByName=createdByName,
                CreatedDate=DateTime.Now,
                ModifiedByName=createdByName,
                ModifiedDate=DateTime.Now,
                IsDeleted=false
            }).ContinueWith(t=>_unitofWork.SaveAsync());
            return new Result(ResultStatus.Success,$"{categoryDto.Name} adlı kategori başarıyla eklenmiştir.");
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

        public async Task<IDataResult<Category>> Get(int categoryId)
        {
            var category = await _unitofWork.Categories.GetAsync(c=>c.Id==categoryId,c=>c.Products);
            if (category!=null)
            {
                return new DataResult<Category>(ResultStatus.Success,category);
            }
            return new DataResult<Category>(ResultStatus.Error, "Böyle bir kategori bulumadı.",null);
        }

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories=await _unitofWork.Categories.GetAllAsync(null,c=>c.Products);
            if (categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success,categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç bir kategori bulumadı.", null);
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNonDeleted()
        {
            var categories = await _unitofWork.Categories.GetAllAsync(c=>!c.IsDeleted,c=>c.Products);
            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç bir kategori bulumadı.", null);
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
            var category = await _unitofWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);
            if (category!=null)
            {
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Note = categoryUpdateDto.Note;
                category.IsActive = categoryUpdateDto.isActive;
                category.CreatedDate = DateTime.Now;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                category.IsDeleted = false;
                await _unitofWork.Categories.UpdateAsync(category).ContinueWith(t=>_unitofWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı kategori başarıyla günlenmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir kategori bulunamadı");
        }
    }
}
