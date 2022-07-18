using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VjezbaZaIspit.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d7ec828-22ee-4fb3-a381-20dc59fcff5e",
                column: "ConcurrencyStamp",
                value: "45eb9175-da1d-4125-b4f7-52ac58530e42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b15772df-590d-412f-baf3-e0a4805c13e0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba3f4e30-08fa-474f-b42c-8e26b1160a98", "AQAAAAEAACcQAAAAEH5YHJuXXt2Sa3hsdoj7HIRUdU0Ku/taEZaEusRvnXiOz7wM7sXqfzyRhL5V8cTJBQ==" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Created", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5861), "Autor 1", "Autor 1" },
                    { 2, new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5915), "Autor 2", "Autor 2" },
                    { 3, new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5925), "Autor 3", "Autor 3" },
                    { 4, new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5934), "Autor 4", "Autor 4" },
                    { 5, new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5945), "Autor 5", "Autor 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d7ec828-22ee-4fb3-a381-20dc59fcff5e",
                column: "ConcurrencyStamp",
                value: "81f85433-c5a4-4acc-b2f7-c517772e3e6e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b15772df-590d-412f-baf3-e0a4805c13e0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4733ef7-b6da-45ee-97c3-eb53688c239f", "AQAAAAEAACcQAAAAEGv0BGOTgzPoIhFGUI0t1Kt8gaVlPUtbw96XuasKYvbg7xyPqGwBkHwCkOqTDwfdPg==" });
        }
    }
}
