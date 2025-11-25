using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CooperchipItDeveloper.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldsImgProfilePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgProfilePath",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgProfilePath",
                table: "AspNetUsers");
        }
    }
}
