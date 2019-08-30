using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class AddOrderForAdmina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83592d47-b723-407a-ab2d-3fed1a402ee9", "AQAAAAEAACcQAAAAEIBro698gktva5Y2HesGCW7fnN+jyXANkiRPwNWZU1Wis4OLPgHoDbbgndWIHHuLQg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77b20a69-b44f-410e-acec-6c0e5c962093", "AQAAAAEAACcQAAAAEMVxOMHnS4ANFdPMQwXGIrrqe4L8MawQCsUkHZuyXJDAu7Rira3eSNc6VCBrU6z8tQ==" });
        }
    }
}
