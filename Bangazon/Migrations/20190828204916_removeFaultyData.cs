using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class removeFaultyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_GroupedProducts_GroupedProductsTypeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductType_ProductTypeViewModel_ProductTypeViewModelProductTypeId",
                table: "ProductType");

            migrationBuilder.DropTable(
                name: "GroupedProducts");

            migrationBuilder.DropTable(
                name: "ProductTypeViewModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductType_ProductTypeViewModelProductTypeId",
                table: "ProductType");

            migrationBuilder.DropIndex(
                name: "IX_Product_GroupedProductsTypeId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductTypeViewModelProductTypeId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "GroupedProductsTypeId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "323c63ac-acfc-4ada-9487-cb8224ca1c73", "AQAAAAEAACcQAAAAEJl788A2YwqTKLjFnfoqyvMnmwSpAPCl9u/Y21biyTgFKmoBAt4e+PHJ7bvDHaDNng==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductTypeViewModelProductTypeId",
                table: "ProductType",
                nullable: true);

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
                    ProductCount = table.Column<int>(nullable: false),
                    ProductTypeViewModelProductTypeId = table.Column<int>(nullable: true),
                    TypeName = table.Column<string>(nullable: true)
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
                values: new object[] { "e9a9d834-0ef6-4a5e-a7b6-cd66a4e87c2a", "AQAAAAEAACcQAAAAENMIT1UBeyL3ObXw1FQvukbzniMD6CqKjzoA291pNJ3m+u1WSNomILNLiDZwQyHodQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductType_ProductTypeViewModelProductTypeId",
                table: "ProductType",
                column: "ProductTypeViewModelProductTypeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductType_ProductTypeViewModel_ProductTypeViewModelProductTypeId",
                table: "ProductType",
                column: "ProductTypeViewModelProductTypeId",
                principalTable: "ProductTypeViewModel",
                principalColumn: "ProductTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
