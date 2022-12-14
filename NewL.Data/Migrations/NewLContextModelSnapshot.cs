﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewL.Data.Concrete.EntityFramework.Contexts;

#nullable disable

namespace NewL.Data.Migrations
{
    [DbContext(typeof(NewLContext))]
    partial class NewLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NewL.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Catagories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8903),
                            Description = "Elektrikli ve elektronik cihaz ve aletlerin tümüdür. Örneğin; Bulaşık makinesi, buzdolabı, elektrik süpürgesi, tost makinesi, telefonlar, bilgisayarlar vb…",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8905),
                            Name = "Elektronik",
                            Note = "Elektronik Kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8910),
                            Description = "Ev & Yaşam dair eşyaların tümüdür.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8911),
                            Name = "Ev & Yaşam",
                            Note = "Ev & Yaşam Kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8915),
                            Description = "Kozmetik & Kişisel Bakım dair eşyaların tümüdür.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8916),
                            Name = "Kozmetik & Kişisel Bakım",
                            Note = "Kozmetik & Kişisel Bakım Kategorisi"
                        });
                });

            modelBuilder.Entity("NewL.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2232),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2233),
                            Note = "Ürün çok iyiydi.",
                            ProductId = 1,
                            Text = "Ürün çok iyiydi."
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2238),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2239),
                            Note = "Ürün eksik ve hatalıydı.",
                            ProductId = 2,
                            Text = "Ürün eksik ve hatalıydı."
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2244),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2245),
                            Note = "Ürün şık ve optimaldi.",
                            ProductId = 3,
                            Text = "Ürün şık ve optimaldi."
                        });
                });

            modelBuilder.Entity("NewL.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategorId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorId");

                    b.HasIndex("UserId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategorId = 1,
                            CommentCount = 1,
                            Content = "Birçok TV markaları mevcuttur.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6558),
                            Date = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6556),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6560),
                            Name = "TV",
                            Note = "TV Kategorisi",
                            SeoDescription = "TV",
                            SeoName = "YazHan",
                            SeoTags = "Vestel,Samsung,LG,Diğer",
                            Thumnail = "Default.jpg",
                            UserId = 1,
                            ViewsCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CategorId = 2,
                            CommentCount = 1,
                            Content = "Birçok Mobilya markaları mevcuttur.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6567),
                            Date = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6565),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6568),
                            Name = "Mobilya",
                            Note = "Mobilya Kategorisi",
                            SeoDescription = "Mobilya",
                            SeoName = "YazHan",
                            SeoTags = "Modalife,Bellona,Diğer",
                            Thumnail = "Default.jpg",
                            UserId = 1,
                            ViewsCount = 295
                        },
                        new
                        {
                            Id = 3,
                            CategorId = 3,
                            CommentCount = 1,
                            Content = "Birçok Saç & Bakım ürünleri mevcuttur.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6574),
                            Date = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6572),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6575),
                            Name = "Saç & Bakım",
                            Note = "Saç & Bakım Kategorisi",
                            SeoDescription = "Saç & Bakım",
                            SeoName = "YazHan",
                            SeoTags = "Diğer",
                            Thumnail = "Default.jpg",
                            UserId = 1,
                            ViewsCount = 10
                        });
                });

            modelBuilder.Entity("NewL.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(4067),
                            Description = "Admin Rolü,Tüm Haklara Sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(4063),
                            Name = "Admin",
                            Note = "Admin Rolüdür."
                        });
                });

            modelBuilder.Entity("NewL.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(9288),
                            Description = "Ilk Admin Kullanıcısı",
                            Email = "yazilimhanem@gmail.com",
                            FirstName = "Yazilim",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Hanem",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(9290),
                            Note = "Admin Kullanıcısı",
                            PasswordHash = new byte[] { 51, 52, 53, 50, 57, 97, 50, 98, 57, 51, 53, 102, 100, 100, 48, 102, 56, 97, 54, 49, 54, 100, 54, 51, 97, 52, 102, 97, 52, 55, 98, 100 },
                            Picture = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.mobilhanem.com%2F&psig=AOvVaw1YnGpjhfi8N0iw84MjcDeF&ust=1670336486676000&source=images&cd=vfe&ved=0CBIQ3YkBahcKEwjg1a651uL7AhUAAAAAHQAAAAAQCQ",
                            RoleId = 1,
                            UserName = "YazHan"
                        });
                });

            modelBuilder.Entity("NewL.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("NewL.Entities.Concrete.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NewL.Entities.Concrete.Product", b =>
                {
                    b.HasOne("NewL.Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewL.Entities.Concrete.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NewL.Entities.Concrete.User", b =>
                {
                    b.HasOne("NewL.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("NewL.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NewL.Entities.Concrete.Product", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("NewL.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("NewL.Entities.Concrete.User", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
