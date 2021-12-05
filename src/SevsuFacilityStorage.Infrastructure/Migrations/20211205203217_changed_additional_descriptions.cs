using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SevsuFacilityStorage.Migrations
{
    public partial class changed_additional_descriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16fe15dd-5040-4d10-abf0-74d94e9c2c02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d7dd624-17b5-460f-b79c-0d1b4e8164fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3615bda8-3970-4796-9e5a-3c5fcb0f2ced");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86b87d04-e91d-4f9d-9041-61107b64e8ec");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropColumn(
                name: "LabClassDescription_Type",
                table: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropColumn(
                name: "PersonalComputersQuantity",
                table: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.AddColumn<Guid>(
                name: "PremisesDescriptionId",
                table: "AdditionalEducationalPremiseDescriptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PremisesDescriptionId",
                table: "AdditionalAdministrativePremiseDescriptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ComputerClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonalComputersQuantity = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComputerClasses_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LabClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabClasses_PremisesDescriptions_PremisesDescriptionId",
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
                    { "55b7c398-fa4f-4b6a-8505-b89ffe1efe63", "c38c17c4-9d54-48e6-972d-659a771a7bb8", "admin", null },
                    { "2d9dbda1-3038-4900-b074-7698d005e9f2", "05aab2f2-565a-40b2-8acc-b7e5b77d9113", "user", null },
                    { "6991fe40-f1f7-4884-a44a-10139d9649e8", "134ecc26-d7dc-42f7-92d7-574754ca1e3d", "moderator", null },
                    { "5818c1e6-b4bd-4094-827f-d0b7c8faca53", "a581346c-6563-4c94-bf25-709c2cbd09b7", "responsible", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalEducationalPremiseDescriptions_PremisesDescriptionId",
                table: "AdditionalEducationalPremiseDescriptions",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalAdministrativePremiseDescriptions_PremisesDescriptionId",
                table: "AdditionalAdministrativePremiseDescriptions",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerClasses_PremisesDescriptionId",
                table: "ComputerClasses",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LabClasses_PremisesDescriptionId",
                table: "LabClasses",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalAdministrativePremiseDescriptions_PremisesDescriptions_PremisesDescriptionId",
                table: "AdditionalAdministrativePremiseDescriptions",
                column: "PremisesDescriptionId",
                principalTable: "PremisesDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalEducationalPremiseDescriptions_PremisesDescriptions_PremisesDescriptionId",
                table: "AdditionalEducationalPremiseDescriptions",
                column: "PremisesDescriptionId",
                principalTable: "PremisesDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalAdministrativePremiseDescriptions_PremisesDescriptions_PremisesDescriptionId",
                table: "AdditionalAdministrativePremiseDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalEducationalPremiseDescriptions_PremisesDescriptions_PremisesDescriptionId",
                table: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropTable(
                name: "ComputerClasses");

            migrationBuilder.DropTable(
                name: "LabClasses");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalEducationalPremiseDescriptions_PremisesDescriptionId",
                table: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalAdministrativePremiseDescriptions_PremisesDescriptionId",
                table: "AdditionalAdministrativePremiseDescriptions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d9dbda1-3038-4900-b074-7698d005e9f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b7c398-fa4f-4b6a-8505-b89ffe1efe63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5818c1e6-b4bd-4094-827f-d0b7c8faca53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6991fe40-f1f7-4884-a44a-10139d9649e8");

            migrationBuilder.DropColumn(
                name: "PremisesDescriptionId",
                table: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropColumn(
                name: "PremisesDescriptionId",
                table: "AdditionalAdministrativePremiseDescriptions");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AdditionalEducationalPremiseDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LabClassDescription_Type",
                table: "AdditionalEducationalPremiseDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalComputersQuantity",
                table: "AdditionalEducationalPremiseDescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "AdditionalEducationalPremiseDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "AdditionalEducationalPremiseDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3615bda8-3970-4796-9e5a-3c5fcb0f2ced", "634bd843-2e24-4abf-bc7d-43e87e05aa69", "admin", null },
                    { "1d7dd624-17b5-460f-b79c-0d1b4e8164fe", "b5863e9f-5c41-4ee0-9afb-356500baf613", "user", null },
                    { "86b87d04-e91d-4f9d-9041-61107b64e8ec", "a9e2263c-1d3f-455a-a50c-b9a5897e89b3", "moderator", null },
                    { "16fe15dd-5040-4d10-abf0-74d94e9c2c02", "c6fcf342-84ed-4d47-bd3e-9c251607397c", "responsible", null }
                });
        }
    }
}
