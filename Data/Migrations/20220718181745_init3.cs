using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VjezbaZaIspit.Data.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d7ec828-22ee-4fb3-a381-20dc59fcff5e",
                column: "ConcurrencyStamp",
                value: "70cadc73-87bb-47f6-9cf7-9270dbbaabf0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b15772df-590d-412f-baf3-e0a4805c13e0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81100b65-5ea4-495d-bde8-620d05495812", "AQAAAAEAACcQAAAAEGyWusmlY2HniSL6u4GYrbq+SduxATMzhFZqp7DGVIIrRu4xjwmcr1h20YWrSQwFfA==" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Created", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9598), "Publisher 1" },
                    { 2, new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9622), "Publisher 2" },
                    { 3, new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9641), "Publisher 3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 13, 58, 501, DateTimeKind.Local).AddTicks(5945));
        }
    }
}
