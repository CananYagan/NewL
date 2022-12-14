using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewL.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategorId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Catagories_CategorId",
                        column: x => x.CategorId,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8903), "Elektrikli ve elektronik cihaz ve aletlerin tümüdür. Örneğin; Bulaşık makinesi, buzdolabı, elektrik süpürgesi, tost makinesi, telefonlar, bilgisayarlar vb…", true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8905), "Elektronik", "Elektronik Kategorisi" },
                    { 2, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8910), "Ev & Yaşam dair eşyaların tümüdür.", true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8911), "Ev & Yaşam", "Ev & Yaşam Kategorisi" },
                    { 3, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8915), "Kozmetik & Kişisel Bakım dair eşyaların tümüdür.", true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(8916), "Kozmetik & Kişisel Bakım", "Kozmetik & Kişisel Bakım Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note" },
                values: new object[] { 1, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(4067), "Admin Rolü,Tüm Haklara Sahiptir.", true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(4063), "Admin", "Admin Rolüdür." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "UserName" },
                values: new object[] { 1, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(9288), "Ilk Admin Kullanıcısı", "yazilimhanem@gmail.com", "Yazilim", true, false, "Hanem", "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(9290), "Admin Kullanıcısı", new byte[] { 51, 52, 53, 50, 57, 97, 50, 98, 57, 51, 53, 102, 100, 100, 48, 102, 56, 97, 54, 49, 54, 100, 54, 51, 97, 52, 102, 97, 52, 55, 98, 100 }, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.mobilhanem.com%2F&psig=AOvVaw1YnGpjhfi8N0iw84MjcDeF&ust=1670336486676000&source=images&cd=vfe&ved=0CBIQ3YkBahcKEwjg1a651uL7AhUAAAAAHQAAAAAQCQ", 1, "YazHan" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategorId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "SeoDescription", "SeoName", "SeoTags", "Thumnail", "UserId", "ViewsCount" },
                values: new object[,]
                {
                    { 1, 1, 1, "Birçok TV markaları mevcuttur.", "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6558), new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6556), true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6560), "TV", "TV Kategorisi", "TV", "YazHan", "Vestel,Samsung,LG,Diğer", "Default.jpg", 1, 100 },
                    { 2, 2, 1, "Birçok Mobilya markaları mevcuttur.", "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6567), new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6565), true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6568), "Mobilya", "Mobilya Kategorisi", "Mobilya", "YazHan", "Modalife,Bellona,Diğer", "Default.jpg", 1, 295 },
                    { 3, 3, 1, "Birçok Saç & Bakım ürünleri mevcuttur.", "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6574), new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6572), true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 282, DateTimeKind.Local).AddTicks(6575), "Saç & Bakım", "Saç & Bakım Kategorisi", "Saç & Bakım", "YazHan", "Diğer", "Default.jpg", 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProductId", "Text" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2232), true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2233), "Ürün çok iyiydi.", 1, "Ürün çok iyiydi." },
                    { 2, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2238), true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2239), "Ürün eksik ve hatalıydı.", 2, "Ürün eksik ve hatalıydı." },
                    { 3, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2244), true, false, "InitialCreate", new DateTime(2022, 12, 5, 17, 23, 17, 283, DateTimeKind.Local).AddTicks(2245), "Ürün şık ve optimaldi.", 3, "Ürün şık ve optimaldi." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategorId",
                table: "Products",
                column: "CategorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
