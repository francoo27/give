using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Give.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCampana : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Campaña",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Campaña",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Campaña",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Campaña",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Campaña");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Campaña");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Campaña");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Campaña");
        }
    }
}
