using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VjezbaZaIspit.Data.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b5b0da-e61e-46ba-b766-e1acc7401352",
                column: "ConcurrencyStamp",
                value: "29a751d7-7eb7-4c36-9f8c-57c3e2f345d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "badd4ddd-df0e-4621-af37-c2b36aaa6742",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cba44e3-49d9-41b0-b728-565207984ca7", "AQAAAAEAACcQAAAAEJETRAgiaLi+DgenuyjUCBRQtHpumP47ubKM77EFGzZf5JRaBQx9r/v4nDKV8p8i6A==" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 42, 47, 626, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 42, 47, 626, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 42, 47, 626, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 42, 47, 626, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 42, 47, 626, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 42, 47, 626, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 42, 47, 626, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 42, 47, 626, DateTimeKind.Local).AddTicks(4637));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b5b0da-e61e-46ba-b766-e1acc7401352",
                column: "ConcurrencyStamp",
                value: "98bd448d-27bd-4c0c-9ed4-3c293ddc18fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "badd4ddd-df0e-4621-af37-c2b36aaa6742",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9980194a-f512-4b51-8fe8-f1c98fbb08c6", "AQAAAAEAACcQAAAAED4fzE0frJnk/CEkIcLXKZjNkBjDQbgeyfysBL88QOzP3+UBrpyxP8rFGM4MN5ZgKw==" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 21, 8, 631, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 21, 8, 631, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 21, 8, 631, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 21, 8, 631, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 21, 8, 631, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 21, 8, 631, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 21, 8, 631, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 21, 8, 631, DateTimeKind.Local).AddTicks(9721));
        }
    }
}
