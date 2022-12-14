using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Data.Abstract
{
    public interface IUnitofWork :IAsyncDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; } //_unitofWork.Categories.AddAsync();
        //_unitofWork.Categories.AddAsync(category);
        //_unitofWork.Categories.AddAsync(user);
        //_unitofWork.SaveAsync();
        Task<int> SaveAsync();
    }
}
