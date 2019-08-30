using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class AddAdminaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da421310-7ead-4918-8b76-9f57b37966c2", "AQAAAAEAACcQAAAAELyEOx1uec3zFbOSUyUS0mnC7XMT1rCoY3hX10MLnKdv3rtR7aAk8nsbItb25u6cSQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83592d47-b723-407a-ab2d-3fed1a402ee9", "AQAAAAEAACcQAAAAEIBro698gktva5Y2HesGCW7fnN+jyXANkiRPwNWZU1Wis4OLPgHoDbbgndWIHHuLQg==" });
        }
    }
}
