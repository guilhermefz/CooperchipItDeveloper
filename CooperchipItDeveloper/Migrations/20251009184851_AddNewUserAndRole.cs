using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CooperchipItDeveloper.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class AddNewUserAndRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ", null, " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ", " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 " });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apelido", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "38D1B050-7F27-4563-903A-277E480B5580", 0, "Poatan", "7ce39772-7007-4335-8be3-944a9d63d583", new DateTime(2025, 10, 9, 15, 48, 49, 738, DateTimeKind.Local).AddTicks(6118), "poatan@gmail.com", true, false, null, "Alex Pereira", "POATAN@GMAIL.COM", "POATAN@GMAIL.COM", "AQAAAAIAAYagAAAAEPYNJB2WBI32Tn7BB/kBUjSF8tHQd5dJ9xxIz/hJX3L8Xxd/0p4/VA8iCfQc7GKyzg==", null, false, "08ca4671-646d-42f5-80df-503ead355f11", false, "poatan@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ", "38D1B050-7F27-4563-903A-277E480B5580" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ", "38D1B050-7F27-4563-903A-277E480B5580" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B5580");
        }
    }
}
