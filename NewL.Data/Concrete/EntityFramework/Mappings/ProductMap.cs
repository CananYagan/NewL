using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewL.Data.Concrete.EntityFramework.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.Name).IsRequired(true);
            builder.Property(p => p.Content).IsRequired();
            builder.Property(p => p.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.SeoName).IsRequired();
            builder.Property(p => p.SeoName).HasMaxLength(50);
            builder.Property(p => p.SeoDescription).HasMaxLength(150);
            builder.Property(p => p.SeoDescription).IsRequired();
            builder.Property(p => p.SeoTags).HasMaxLength(70);
            builder.Property(p => p.SeoTags).IsRequired();
            builder.Property(p => p.ViewsCount).IsRequired();
            builder.Property(p => p.CommentCount).IsRequired();
            builder.Property(p => p.Thumnail).HasMaxLength(250);
            builder.Property(p => p.Thumnail).IsRequired();
            builder.Property(p => p.CreatedByName).HasMaxLength(50);
            builder.Property(p => p.CreatedByName).IsRequired();
            builder.Property(p => p.ModifiedByName).HasMaxLength(50);
            builder.Property(p => p.ModifiedByName).IsRequired();
            builder.Property(p => p.CreatedDate).IsRequired();
            builder.Property(p => p.ModifiedDate).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired();
            builder.Property(p => p.Note).HasMaxLength(500);
            builder.HasOne<Category>(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategorId);
            builder.HasOne<User>(p => p.User).WithMany(u => u.Products).HasForeignKey(p => p.UserId);
            builder.ToTable("Products");
            builder.HasData(

            new Product
            {
                Id = 1,
                CategorId = 1,
                Name = "TV",
                Content = "Birçok TV markaları mevcuttur.",
                Thumnail = "Default.jpg",
                SeoDescription = "TV",
                SeoName = "YazHan",
                SeoTags = "Vestel,Samsung,LG,Diğer",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "TV Kategorisi",
                UserId = 1,
                ViewsCount = 100,
                CommentCount = 1
            },
            new Product
            {
                Id = 2,
                CategorId = 2,
                Name = "Mobilya",
                Content = "Birçok Mobilya markaları mevcuttur.",
                Thumnail = "Default.jpg",
                SeoDescription = "Mobilya",
                SeoName = "YazHan",
                SeoTags = "Modalife,Bellona,Diğer",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Mobilya Kategorisi",
                UserId = 1,
                ViewsCount = 295,
                CommentCount = 1
            },
            new Product
            {
                Id = 3,
                CategorId = 3,
                Name = "Saç & Bakım",
                Content = "Birçok Saç & Bakım ürünleri mevcuttur.",
                Thumnail = "Default.jpg",
                SeoDescription = "Saç & Bakım",
                SeoName = "YazHan",
                SeoTags = "Diğer",
                Date = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "Saç & Bakım Kategorisi",
                UserId = 1,
                ViewsCount = 10,
                CommentCount = 1
            });
        }
    }
}
