using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagemnet.Data.Migrations
{
    /// <inheritdoc />
    public partial class Countries2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedbyId",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedbyId",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CreatedbyId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CreatedbyId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Cities");
        }
    }
}
