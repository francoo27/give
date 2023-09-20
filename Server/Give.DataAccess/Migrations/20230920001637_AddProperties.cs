using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Give.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LaunchDate",
                table: "Campaign",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Campaign",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaunchDate",
                table: "Campaign");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Campaign");
        }
    }
}
