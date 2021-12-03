using Microsoft.EntityFrameworkCore.Migrations;

namespace SevsuFacilityStorage.Migrations
{
    public partial class subPremises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllowedJobsQuantity",
                table: "PremisesDescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AvailableSeatsQuantity",
                table: "PremisesDescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BoardType",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FilledfJobsQuantity",
                table: "PremisesDescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasBoard",
                table: "PremisesDescriptions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasStorage",
                table: "PremisesDescriptions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasTeachingAids",
                table: "PremisesDescriptions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabClassDescription_Type",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalComputersQuantity",
                table: "PremisesDescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherJobsQuantity",
                table: "PremisesDescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47646cf2-73c9-4ddd-9d89-03b82f47644e", "6d7e265e-1a15-4bc5-b6ca-b6aa4bad4261", "admin", null },
                    { "c63f3c61-0119-4d20-bc1a-951d4ba7efc8", "6c002ad9-db38-4d6d-82da-fa26c126155c", "user", null },
                    { "8b12dd33-389b-4e4a-a8ea-57d20fd27204", "d89e25a9-9455-41ff-b090-83be3dd0f68e", "moderator", null },
                    { "51b8e6f4-8ff3-42a7-988c-d2da305b403b", "1e323b54-2ed0-4cf5-bf8f-364c31fe1d95", "responsible", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropColumn(
                name: "AllowedJobsQuantity",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "AvailableSeatsQuantity",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "BoardType",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "FilledfJobsQuantity",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "HasBoard",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "HasStorage",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "HasTeachingAids",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "LabClassDescription_Type",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "PersonalComputersQuantity",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "TeacherJobsQuantity",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "PremisesDescriptions");
        }
    }
}
