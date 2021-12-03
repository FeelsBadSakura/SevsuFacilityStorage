using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SevsuFacilityStorage.Migrations
{
    public partial class Second_Version_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCurrentInformation",
                table: "PremisesDescriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InnerNumber",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberByBTI",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "DateOfCurrentInformation",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "InnerNumber",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "NumberByBTI",
                table: "PremisesDescriptions");
        }
    }
}
