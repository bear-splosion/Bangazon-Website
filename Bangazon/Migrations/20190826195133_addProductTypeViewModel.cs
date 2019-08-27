using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class addProductTypeViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GroupedProductsTypeId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductTypeViewModel",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeViewModel", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GroupedProducts",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(nullable: true),
                    ProductCount = table.Column<int>(nullable: false),
                    ProductTypeViewModelProductTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupedProducts", x => x.TypeId);
                    table.ForeignKey(
                        name: "FK_GroupedProducts_ProductTypeViewModel_ProductTypeViewModelProductTypeId",
                        column: x => x.ProductTypeViewModelProductTypeId,
                        principalTable: "ProductTypeViewModel",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20322e61-8117-42b3-9a01-38b1905c20ce", "AQAAAAEAACcQAAAAEBFtI7ikMpvB2AUxBVGu6NmcIYlVw1Z/25h4VQnrUdef/yuyX7AcY26KhpKOU4skwQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_GroupedProductsTypeId",
                table: "Product",
                column: "GroupedProductsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupedProducts_ProductTypeViewModelProductTypeId",
                table: "GroupedProducts",
                column: "ProductTypeViewModelProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_GroupedProducts_GroupedProductsTypeId",
                table: "Product",
                column: "GroupedProductsTypeId",
                principalTable: "GroupedProducts",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_GroupedProducts_GroupedProductsTypeId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "GroupedProducts");

            migrationBuilder.DropTable(
                name: "ProductTypeViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Product_GroupedProductsTypeId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "GroupedProductsTypeId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc241329-f57e-4baa-9f37-111e2a47a4f8", "AQAAAAEAACcQAAAAEFlqswVbxloLzh2NyW4I1J4QCln3Kdncql2XIwGewtF25/ARLw6TNnDm17oGOz0mWA==" });
        }
    }
}
