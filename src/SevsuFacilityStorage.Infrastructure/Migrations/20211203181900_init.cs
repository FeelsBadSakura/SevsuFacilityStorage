using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SevsuFacilityStorage.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47646cf2-73c9-4ddd-9d89-03b82f47644e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51b8e6f4-8ff3-42a7-988c-d2da305b403b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b12dd33-389b-4e4a-a8ea-57d20fd27204");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c63f3c61-0119-4d20-bc1a-951d4ba7efc8");

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

            migrationBuilder.CreateTable(
                name: "AdditionalAdministrativePremiseDescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AllowedJobsQuantity = table.Column<int>(type: "int", nullable: false),
                    FilledfJobsQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalAdministrativePremiseDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalCharacteristics",
                columns: table => new
                {
                    PremisesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdditionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCharacteristics", x => new { x.AdditionalId, x.PremisesId });
                });

            migrationBuilder.CreateTable(
                name: "AdditionalEducationalPremiseDescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvailableSeatsQuantity = table.Column<int>(type: "int", nullable: false),
                    TeacherJobsQuantity = table.Column<int>(type: "int", nullable: false),
                    HasBoard = table.Column<bool>(type: "bit", nullable: false),
                    BoardType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasStorage = table.Column<bool>(type: "bit", nullable: false),
                    HasTeachingAids = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalComputersQuantity = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabClassDescription_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalEducationalPremiseDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurposeOfPremises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurposeOfPremises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurposeOfPremises_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "92606046-3afe-4ae6-a893-619bf497e3ed", "6b975d6c-9094-4d79-a517-98d13588f258", "admin", null },
                    { "d113e2ee-acb8-4074-8363-c26280383ebc", "625e187b-8e5a-4e85-a449-b50da12b9a6d", "user", null },
                    { "8f1b1998-2cf9-4a00-a473-0f56feec1b3f", "d48ee79c-7eb9-4f52-ab86-38692c23ff0c", "moderator", null },
                    { "3f9ef23b-6a39-4be4-9eb0-4603380253b1", "76ffd704-bb5e-4419-8dd0-470bbe988250", "responsible", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurposeOfPremises_PremisesDescriptionId",
                table: "PurposeOfPremises",
                column: "PremisesDescriptionId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalAdministrativePremiseDescriptions");

            migrationBuilder.DropTable(
                name: "AdditionalCharacteristics");

            migrationBuilder.DropTable(
                name: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropTable(
                name: "PurposeOfPremises");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f9ef23b-6a39-4be4-9eb0-4603380253b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f1b1998-2cf9-4a00-a473-0f56feec1b3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92606046-3afe-4ae6-a893-619bf497e3ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d113e2ee-acb8-4074-8363-c26280383ebc");

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
    }
}
