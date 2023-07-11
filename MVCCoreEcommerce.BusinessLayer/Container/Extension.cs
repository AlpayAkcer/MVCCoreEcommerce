using Microsoft.Extensions.DependencyInjection;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.BusinessLayer.Concrete;
using MVCCoreEcommerce.DataAccessLayer.Abstract;
using MVCCoreEcommerce.DataAccessLayer.EntityFramework;

namespace MVCCoreEcommerce.BusinessLayer.Container
{
    public static class Extension
    {
        //Bu kısmı ekledikten sonra startup kısmına ekle. servis ismini
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

        }
    }
}
