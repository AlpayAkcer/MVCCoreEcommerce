using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCCoreEcommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogContent> BlogContents { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderLine> OrderLines { get; set; }
        //public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductCategory> ProductCategories { get; set; }
        //public DbSet<Property> Properties { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Tax> Taxes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial catalog=MvcCoreEcommerceDB;integrated security=true;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<About>().HasData(new About
        //    {
        //        AboutID = 1,
        //        Name = "Foo",
        //        Description = "Bar",
        //        Picture = "test.jpg",
        //        IsStatus = true
        //    });

        //    modelBuilder.Entity<BlogCategory>().HasData(new BlogCategory
        //    {
        //        BlogCategoryID = 1,
        //        Name = "Foo",
        //        Description = "Bar",
        //        Picture = "test.jpg",
        //        IsStatus = true
        //    });

        //    modelBuilder.Entity<BlogContent>().HasData(new BlogContent
        //    {
        //        BlogContentID = 1,
        //        BlogCategoryID = 1,
        //        Name = "Foo",
        //        Description = "Bar",
        //        IsStatus = true,
        //        Picture = "test.jpg"
        //    });

        //    modelBuilder.Entity<Brand>().HasData(
        //        new Brand
        //        {
        //            BrandID = 1,
        //            Name = "Adidas",
        //            Description = "Kalitenin adresi",
        //            Picture = "adidas.png",
        //            IsStatus = true
        //        },
        //        new Brand
        //        {
        //            BrandID = 2,
        //            Name = "Nike",
        //            Description = "Herkese nasip olmaz",
        //            Picture = "nike.png",
        //            IsStatus = true
        //        },
        //        new Brand
        //        {
        //            BrandID = 3,
        //            Name = "New Balance",
        //            Description = "Uzaklarda arama",
        //            Picture = "newbalance.png",
        //            IsStatus = true
        //        });
        //}
    }
}