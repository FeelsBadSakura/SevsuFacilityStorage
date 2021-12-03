using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SevsuFacilityStorage.Migrations
{
    public partial class version_without_ensuringsecurity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NetworkCharacteristics_ElectricitySupply_ElectricitySupplyId",
                table: "NetworkCharacteristics");

            migrationBuilder.DropIndex(
                name: "IX_Softwares_PremisesDescriptionId",
                table: "Softwares");

            migrationBuilder.DropIndex(
                name: "IX_NetworkCharacteristics_ElectricitySupplyId",
                table: "NetworkCharacteristics");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_PremisesDescriptionId",
                table: "Equipment");

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

            migrationBuilder.DropColumn(
                name: "CharacteristicsOfPurchaseAgreement",
                table: "Softwares");

            migrationBuilder.DropColumn(
                name: "ElectricitySupplyId",
                table: "NetworkCharacteristics");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "PremisesDescriptions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ElectricitySupply",
                newName: "StandartSocketQuantity");

            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Windows",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalInfo",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtractFromEGRN",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Floor",
                table: "PremisesDescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HousingIndex",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Index",
                table: "PremisesDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CeilingCovering",
                table: "GeneralInformation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NetworkCharacteristicsId",
                table: "GeneralInformation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HighSocketQuantity",
                table: "ElectricitySupply",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHighSocket",
                table: "ElectricitySupply",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_PremisesDescriptionId",
                table: "Softwares",
                column: "PremisesDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInformation_NetworkCharacteristicsId",
                table: "GeneralInformation",
                column: "NetworkCharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PremisesDescriptionId",
                table: "Equipment",
                column: "PremisesDescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralInformation_NetworkCharacteristics_NetworkCharacteristicsId",
                table: "GeneralInformation",
                column: "NetworkCharacteristicsId",
                principalTable: "NetworkCharacteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralInformation_NetworkCharacteristics_NetworkCharacteristicsId",
                table: "GeneralInformation");

            migrationBuilder.DropIndex(
                name: "IX_Softwares_PremisesDescriptionId",
                table: "Softwares");

            migrationBuilder.DropIndex(
                name: "IX_GeneralInformation_NetworkCharacteristicsId",
                table: "GeneralInformation");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_PremisesDescriptionId",
                table: "Equipment");

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
                name: "Area",
                table: "Windows");

            migrationBuilder.DropColumn(
                name: "AdditionalInfo",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "ExtractFromEGRN",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "Floor",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "HousingIndex",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "Index",
                table: "PremisesDescriptions");

            migrationBuilder.DropColumn(
                name: "CeilingCovering",
                table: "GeneralInformation");

            migrationBuilder.DropColumn(
                name: "NetworkCharacteristicsId",
                table: "GeneralInformation");

            migrationBuilder.DropColumn(
                name: "HighSocketQuantity",
                table: "ElectricitySupply");

            migrationBuilder.DropColumn(
                name: "IsHighSocket",
                table: "ElectricitySupply");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PremisesDescriptions",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "StandartSocketQuantity",
                table: "ElectricitySupply",
                newName: "Quantity");

            migrationBuilder.AddColumn<string>(
                name: "CharacteristicsOfPurchaseAgreement",
                table: "Softwares",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ElectricitySupplyId",
                table: "NetworkCharacteristics",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_Softwares_PremisesDescriptionId",
                table: "Softwares",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NetworkCharacteristics_ElectricitySupplyId",
                table: "NetworkCharacteristics",
                column: "ElectricitySupplyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PremisesDescriptionId",
                table: "Equipment",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NetworkCharacteristics_ElectricitySupply_ElectricitySupplyId",
                table: "NetworkCharacteristics",
                column: "ElectricitySupplyId",
                principalTable: "ElectricitySupply",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
