using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCCoreEcommerce.BusinessLayer.Container;
using MVCCoreEcommerce.BusinessLayer.Validator;
using MVCCoreEcommerce.DataAccessLayer.Concrete;
using MVCCoreEcommerce.DtoLayer.Dto.AppUserDto;
using MVCCoreEcommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<Context>();

            //AppUser ve AppRole entity eklendikten ve DTO kýsmýna custom validator eklendikten sonra burasý eklenmeli.
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<Context>()
                .AddErrorDescriber<CustomIdentityValidator>()
                .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider)
                .AddEntityFrameworkStores<Context>();

            services.AddTransient<IValidator<AppUserLogInDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<AppUserRegisterDto>, AppUserRegisterValidator>();

            //Business katmanýndaki container içindeki verileri barýndýrýr.
            services.ContainerDependencies();

            services.AddHttpClient();

            //Kullanýcý sayfalarýný yaptýktan sonra, startup kýsmýna autorize olabilmesi için bu ayarýn ve altýndaki ayarýn eklenmesi gerekiyor.
            //Altta ayar ise, kullanýcý veya adminin giriþ yapmasý gereken yolu ve ne kadar zaman cookiede saklanmasýný belirtiyor.
            //options dedikten sonra bir çok ayar var kontrol edilmesi gerekiyor.Ýsteðe göre ayarlar çoðaltýlabilir.
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.LoginPath = "/Login/";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //identity eklendikten sonra buda eklenmeli
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

        }
    }
}
