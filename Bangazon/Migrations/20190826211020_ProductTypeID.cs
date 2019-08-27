using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class ProductTypeID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeViewModelProductTypeId",
                table: "ProductType",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductType_ProductTypeViewModel_ProductTypeViewModelProductTypeId",
                table: "ProductType",
                column: "ProductTypeViewModelProductTypeId",
                principalTable: "ProductTypeViewModel",
                principalColumn: "ProductTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductType_ProductTypeViewModel_ProductTypeViewModelProductTypeId",
                table: "ProductType");

            migrationBuilder.DropIndex(
                name: "IX_ProductType_ProductTypeViewModelProductTypeId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "ProductTypeViewModelProductTypeId",
                table: "ProductType");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "20322e61-8117-42b3-9a01-38b1905c20ce", "AQAAAAEAACcQAAAAEBFtI7ikMpvB2AUxBVGu6NmcIYlVw1Z/25h4VQnrUdef/yuyX7AcY26KhpKOU4skwQ==" });
        }
    }
}
