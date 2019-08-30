using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class AddAnotherOrderForAdmina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77b20a69-b44f-410e-acec-6c0e5c962093", "AQAAAAEAACcQAAAAEMVxOMHnS4ANFdPMQwXGIrrqe4L8MawQCsUkHZuyXJDAu7Rira3eSNc6VCBrU6z8tQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "323c63ac-acfc-4ada-9487-cb8224ca1c73", "AQAAAAEAACcQAAAAEJl788A2YwqTKLjFnfoqyvMnmwSpAPCl9u/Y21biyTgFKmoBAt4e+PHJ7bvDHaDNng==" });
        }
    }
}
