using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CooperchipItDeveloper.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class Ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B5580",
                columns: new[] { "ConcurrencyStamp", "DataNascimento", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab396468-a50b-44e0-84aa-2f2be69e8f66", new DateTime(2025, 10, 9, 15, 57, 41, 981, DateTimeKind.Local).AddTicks(3824), "AQAAAAIAAYagAAAAEM3r6t9GKTyjy1FSuFKOh6xPMXAUi6cPMHgFpQ+NkBgv7o5ZzxxaeH2V3iHoXSyT0g==", "b215f358-1aeb-45da-947c-06470b3451a6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B5580",
                columns: new[] { "ConcurrencyStamp", "DataNascimento", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77362f96-692c-4384-9474-6827052a55b3", new DateTime(2025, 10, 9, 15, 53, 54, 730, DateTimeKind.Local).AddTicks(9196), "AQAAAAIAAYagAAAAEMKUewfkqB1QnDRnR30g3yH7oNLXk3ACNht0bQ72ljmfHuebsg1TCS9sldUscNAn2A==", "e280f082-1cd0-4749-80d2-7ee871467cae" });
        }
    }
}
