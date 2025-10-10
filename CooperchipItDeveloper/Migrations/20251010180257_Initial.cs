using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CooperchipItDeveloper.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B548D",
                columns: new[] { "ConcurrencyStamp", "DataNascimento", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fcf865d-e5d2-4d4f-a9db-352c0b00c976", new DateTime(2025, 10, 10, 15, 2, 57, 172, DateTimeKind.Local).AddTicks(4737), "AQAAAAIAAYagAAAAEACyX0k4WmO4OoHYjytKolAfPAExbGBf8+hR1+K+dkb7QBILEQCwaTdDgoS7Nlya5w==", "cdf1e785-18f6-471c-8cff-8d30c5e460c0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B548D",
                columns: new[] { "ConcurrencyStamp", "DataNascimento", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc164d0-8e15-4340-b388-d7b698394ef8", new DateTime(2025, 10, 9, 16, 36, 16, 278, DateTimeKind.Local).AddTicks(735), "AQAAAAIAAYagAAAAEPtOHxIL0A0IE2W/Ik37k7c8hZTbGVopTobzjw5wKh2AwXQhdwqZtKOOXWN4ipHYgw==", "aa7a9f39-3b97-49e1-a015-183134524287" });
        }
    }
}
