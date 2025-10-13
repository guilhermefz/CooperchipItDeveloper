using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CooperchipItDeveloper.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class appendCidData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B548D",
                columns: new[] { "ConcurrencyStamp", "DataNascimento", "PasswordHash", "SecurityStamp" },
                values: new object[] { "713d37ea-d561-42ee-bd64-2fc2bbd95a54", new DateTime(2025, 10, 10, 17, 9, 45, 269, DateTimeKind.Local).AddTicks(244), "AQAAAAIAAYagAAAAEBlSsZVOIZ+L5CWv0CtoFdPV5rvQl6tawDJUL0bS9BKSUmiiUfmOpwCNZvFE+GkW2w==", "33cec146-24ff-41c7-a3e1-1403f1fbb554" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B548D",
                columns: new[] { "ConcurrencyStamp", "DataNascimento", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fcf865d-e5d2-4d4f-a9db-352c0b00c976", new DateTime(2025, 10, 10, 15, 2, 57, 172, DateTimeKind.Local).AddTicks(4737), "AQAAAAIAAYagAAAAEACyX0k4WmO4OoHYjytKolAfPAExbGBf8+hR1+K+dkb7QBILEQCwaTdDgoS7Nlya5w==", "cdf1e785-18f6-471c-8cff-8d30c5e460c0" });
        }
    }
}
