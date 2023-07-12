using Microsoft.Extensions.DependencyInjection;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.BusinessLayer.Concrete;
using MVCCoreEcommerce.DataAccessLayer.Abstract;
using MVCCoreEcommerce.DataAccessLayer.EntityFramework;
using System.Linq;

namespace MVCCoreEcommerce.BusinessLayer.Container
{
    public static class Extension
    {
        //Bu kısmı ekledikten sonra startup kısmına ekle. servis ismini
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>().Reverse();
            services.AddScoped<ICategoryDal, EfCategoryDal>().Reverse();

            services.AddScoped<IBannerService, BannerManager>().Reverse();
            services.AddScoped<IBannerDal, EfBannerDal>().Reverse();

            services.AddScoped<IBrandService, BrandManager>().Reverse();
            services.AddScoped<IBrandDal, EfBrandDal>().Reverse();

            services.AddScoped<IBlogCategoryService, BlogCategoryManager>().Reverse();
            services.AddScoped<IBlogCategoryDal, EfBlogCategoryDal>().Reverse();

            services.AddScoped<IBlogContentService, BlogContentManager>().Reverse();
            services.AddScoped<IBlogContentDal, EfBlogContentDal>().Reverse();

            services.AddScoped<IContactService, ContactManager>().Reverse();
            services.AddScoped<IContactDal, EfContactDal>().Reverse();

            services.AddScoped<IExcelService, ExcelManager>().Reverse();

            services.AddScoped<IMessageService, MessageManager>().Reverse();
            services.AddScoped<IMessageDal, EfMessageDal>().Reverse();

            services.AddScoped<INewsletterService, NewsletterManager>().Reverse();
            services.AddScoped<INewsletterDal, EfNewsletterDal>().Reverse();

            services.AddScoped<INewsService, NewsManager>().Reverse();
            services.AddScoped<INewsDal, EfNewsDal>().Reverse();

            services.AddScoped<IOrderService, OrderManager>().Reverse();
            services.AddScoped<IOrderDal, EfOrderDal>().Reverse();

            services.AddScoped<IProductService, ProductManager>().Reverse();
            services.AddScoped<IProductDal, EfProductDal>().Reverse();

            services.AddScoped<ISettingService, SettingManager>().Reverse();
            services.AddScoped<ISettingDal, EfSettingDal>().Reverse();

            services.AddScoped<IStatusService, StatusManager>().Reverse();
            services.AddScoped<IStatusDal, EfStatusDal>().Reverse();

            services.AddScoped<ISocialService, SocialManager>().Reverse();
            services.AddScoped<ISocialDal, EfSocialDal>().Reverse();

            services.AddScoped<ITaxService, TaxManager>().Reverse();
            services.AddScoped<ITaxDal, EfTaxDal>().Reverse();
        }
    }
}
