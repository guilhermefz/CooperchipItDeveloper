using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CooperchipItDeveloper.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class Ajuste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ",
                column: "Name",
                value: "Convidado");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B5580",
                columns: new[] { "ConcurrencyStamp", "DataNascimento", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77362f96-692c-4384-9474-6827052a55b3", new DateTime(2025, 10, 9, 15, 53, 54, 730, DateTimeKind.Local).AddTicks(9196), "AQAAAAIAAYagAAAAEMKUewfkqB1QnDRnR30g3yH7oNLXk3ACNht0bQ72ljmfHuebsg1TCS9sldUscNAn2A==", "e280f082-1cd0-4749-80d2-7ee871467cae" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ",
                column: "Name",
                value: " F58EB8E9 - 4BD4 - 4398 - A7BC - F76F9CB0F1E0 ");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38D1B050-7F27-4563-903A-277E480B5580",
                columns: new[] { "ConcurrencyStamp", "DataNascimento", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ce39772-7007-4335-8be3-944a9d63d583", new DateTime(2025, 10, 9, 15, 48, 49, 738, DateTimeKind.Local).AddTicks(6118), "AQAAAAIAAYagAAAAEPYNJB2WBI32Tn7BB/kBUjSF8tHQd5dJ9xxIz/hJX3L8Xxd/0p4/VA8iCfQc7GKyzg==", "08ca4671-646d-42f5-80df-503ead355f11" });
        }
    }
}
