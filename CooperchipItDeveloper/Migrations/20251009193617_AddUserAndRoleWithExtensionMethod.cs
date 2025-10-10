using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CooperchipItDeveloper.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAndRoleWithExtensionMethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "F58EB8E9-4BD4-4398-A7BC-F76F9CB0F021", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apelido", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "38D1B050-7F27-4563-903A-277E480B548D", 0, "Charles do Bronx", "cbc164d0-8e15-4340-b388-d7b698394ef8", new DateTime(2025, 10, 9, 16, 36, 16, 278, DateTimeKind.Local).AddTicks(735), "iluminado@gmail.com", true, false, null, "Charles Oliveira", "ILUMINADO@GMAIL.COM", "ILUMINADO@GMAIL.COM", "AQAAAAIAAYagAAAAEPtOHxIL0A0IE2W/Ik37k7c8hZTbGVopTobzjw5wKh2AwXQhdwqZtKOOXWN4ipHYgw==", null, false, "aa7a9f39-3b97-49e1-a015-183134524287", false, "iluminado@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "F58EB8E9-4BD4-4398-A7BC-F76F9CB0F021", "38D1B050-7F27-4563-903A-277E480B548D" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F58EB8E9-4BD4-4398-A7BC-F76F9CB0F021", "38D1B050-7F27-4563-903A-277E480B548D" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F58EB8E9-4BD4-4398-A7BC-F76F9CB0F021");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B548D");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ", null, "Convidado", " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 " });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Apelido", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "38D1B050-7F27-4563-903A-277E480B5580", 0, "Poatan", "ab396468-a50b-44e0-84aa-2f2be69e8f66", new DateTime(2025, 10, 9, 15, 57, 41, 981, DateTimeKind.Local).AddTicks(3824), "poatan@gmail.com", true, false, null, "Alex Pereira", "POATAN@GMAIL.COM", "POATAN@GMAIL.COM", "AQAAAAIAAYagAAAAEM3r6t9GKTyjy1FSuFKOh6xPMXAUi6cPMHgFpQ+NkBgv7o5ZzxxaeH2V3iHoXSyT0g==", null, false, "b215f358-1aeb-45da-947c-06470b3451a6", false, "poatan@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ", "38D1B050-7F27-4563-903A-277E480B5580" });
        }
    }
}
