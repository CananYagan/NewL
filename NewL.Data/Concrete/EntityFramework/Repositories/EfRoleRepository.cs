using Microsoft.EntityFrameworkCore;
using NewL.Data.Abstract;
using NewL.Entities.Concrete;
using NewL.Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Data.Concrete.EntityFramework.Repositories
{
    public class EfRoleRepository : EfEntityRepositoryBase<Role>, IRoleRepository
    {
        public EfRoleRepository(DbContext context) : base(context)
        {
        }
    }
}
