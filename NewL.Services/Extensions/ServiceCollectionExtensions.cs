
using Microsoft.Extensions.DependencyInjection;
using NewL.Data.Abstract;
using NewL.Data.Concrete;
using NewL.Data.Concrete.EntityFramework.Contexts;
using NewL.Services.Abstract;
using NewL.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<NewLContext>();
            serviceCollection.AddScoped<IUnitofWork, UnitofWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IProductService, ProductManager>();
            return serviceCollection;
        }
        
    }
}
