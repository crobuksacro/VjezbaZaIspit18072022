using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VjezbaZaIspit.Data.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d7ec828-22ee-4fb3-a381-20dc59fcff5e", "b15772df-590d-412f-baf3-e0a4805c13e0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d7ec828-22ee-4fb3-a381-20dc59fcff5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b15772df-590d-412f-baf3-e0a4805c13e0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6b5b0da-e61e-46ba-b766-e1acc7401352", "98bd448d-27bd-4c0c-9ed4-3c293ddc18fd", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "badd4ddd-df0e-4621-af37-c2b36aaa6742", 0, "9980194a-f512-4b51-8fe8-f1c98fbb08c6", "admin@admin.com", true, "Ivan", "Radoš", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAED4fzE0frJnk/CEkIcLXKZjNkBjDQbgeyfysBL88QOzP3+UBrpyxP8rFGM4MN5ZgKw==", null, false, "c8c5cc23-1703-4984-8ac7-4b178d2d9982", false, "admin@admin.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d6b5b0da-e61e-46ba-b766-e1acc7401352", "badd4ddd-df0e-4621-af37-c2b36aaa6742" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6b5b0da-e61e-46ba-b766-e1acc7401352", "badd4ddd-df0e-4621-af37-c2b36aaa6742" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6b5b0da-e61e-46ba-b766-e1acc7401352");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "badd4ddd-df0e-4621-af37-c2b36aaa6742");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7d7ec828-22ee-4fb3-a381-20dc59fcff5e", "70cadc73-87bb-47f6-9cf7-9270dbbaabf0", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b15772df-590d-412f-baf3-e0a4805c13e0", 0, "81100b65-5ea4-495d-bde8-620d05495812", "admin@admin.com", true, "Ivan", "Radoš", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGyWusmlY2HniSL6u4GYrbq+SduxATMzhFZqp7DGVIIrRu4xjwmcr1h20YWrSQwFfA==", null, false, "d9635ef5-e580-4a00-8fe1-9d35d0cef6d3", false, "admin@admin.com" });

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

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 18, 20, 17, 45, 514, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7d7ec828-22ee-4fb3-a381-20dc59fcff5e", "b15772df-590d-412f-baf3-e0a4805c13e0" });
        }
    }
}
