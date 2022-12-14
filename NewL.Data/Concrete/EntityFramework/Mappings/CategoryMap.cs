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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(50);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Catagories");
            builder.HasData(
                new Category
                {
                    Id=1,
                    Name="Elektronik",
                    Description= "Elektrikli ve elektronik cihaz ve aletlerin tümüdür." +
                    " Örneğin; Bulaşık makinesi, buzdolabı, elektrik süpürgesi, tost makinesi, telefonlar, bilgisayarlar vb…",
                    IsActive=true, 
                    IsDeleted=false,
                    CreatedByName="InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName= "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note= "Elektronik Kategorisi"
                },
                new Category
                {
                    Id = 2,
                    Name = "Ev & Yaşam",
                    Description = "Ev & Yaşam dair eşyaların tümüdür.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Ev & Yaşam Kategorisi"
                },
                new Category
                {
                    Id = 3,
                    Name = "Kozmetik & Kişisel Bakım",
                    Description = "Kozmetik & Kişisel Bakım dair eşyaların tümüdür.",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "Kozmetik & Kişisel Bakım Kategorisi"
                });


        }
    }
}
