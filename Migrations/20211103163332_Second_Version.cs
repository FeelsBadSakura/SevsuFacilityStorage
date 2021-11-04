using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SevsuFacilityStorage.Migrations
{
    public partial class Second_Version : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricitySupply",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStandartSocket = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    IsDeEnergizingDevice = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricitySupply", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PremisesDescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremisesDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NetworkCharacteristics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsRJ45Socket = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    SocketsOccupied = table.Column<int>(type: "int", nullable: false),
                    IsLVC = table.Column<bool>(type: "bit", nullable: false),
                    IsFHDNetwork = table.Column<bool>(type: "bit", nullable: false),
                    IsInternerAccess = table.Column<bool>(type: "bit", nullable: false),
                    ElectricitySupplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NetworkCharacteristics_ElectricitySupply_ElectricitySupplyId",
                        column: x => x.ElectricitySupplyId,
                        principalTable: "ElectricitySupply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessibilityForPersonsWithDisabilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailabilityCharacteristics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibilityForPersonsWithDisabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessibilityForPersonsWithDisabilities_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnsuringSecurities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HasAutomaticNotificationSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasSecurityAlarmSystem = table.Column<bool>(type: "bit", nullable: false),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnsuringSecurities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnsuringSecurities_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventoryNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    WallCovering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorCovering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricitySupplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralInformation_ElectricitySupply_ElectricitySupplyId",
                        column: x => x.ElectricitySupplyId,
                        principalTable: "ElectricitySupply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneralInformation_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepairStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnderRepair = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlannedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairStatuses_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibilityForPremises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibilityForPremises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsibilityForPremises_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharacteristicsOfPurchaseAgreement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Softwares_PremisesDescriptions_PremisesDescriptionId",
                        column: x => x.PremisesDescriptionId,
                        principalTable: "PremisesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireExtinguishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    EnsuringSecurityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireExtinguishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireExtinguishers_EnsuringSecurities_EnsuringSecurityId",
                        column: x => x.EnsuringSecurityId,
                        principalTable: "EnsuringSecurities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsElectronicLock = table.Column<bool>(type: "bit", nullable: false),
                    GeneralInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doors_GeneralInformation_GeneralInformationId",
                        column: x => x.GeneralInformationId,
                        principalTable: "GeneralInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Heatings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    GeneralInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heatings_GeneralInformation_GeneralInformationId",
                        column: x => x.GeneralInformationId,
                        principalTable: "GeneralInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LightingDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    GeneralInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightingDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LightingDevices_GeneralInformation_GeneralInformationId",
                        column: x => x.GeneralInformationId,
                        principalTable: "GeneralInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Windows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Obstacles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grids = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Windows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Windows_GeneralInformation_GeneralInformationId",
                        column: x => x.GeneralInformationId,
                        principalTable: "GeneralInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibilityForPremisesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RepairStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_RepairStatuses_RepairStatusId",
                        column: x => x.RepairStatusId,
                        principalTable: "RepairStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_ResponsibilityForPremises_ResponsibilityForPremisesId",
                        column: x => x.ResponsibilityForPremisesId,
                        principalTable: "ResponsibilityForPremises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessibilityForPersonsWithDisabilities_PremisesDescriptionId",
                table: "AccessibilityForPersonsWithDisabilities",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doors_GeneralInformationId",
                table: "Doors",
                column: "GeneralInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EnsuringSecurities_PremisesDescriptionId",
                table: "EnsuringSecurities",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PremisesDescriptionId",
                table: "Equipment",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FireExtinguishers_EnsuringSecurityId",
                table: "FireExtinguishers",
                column: "EnsuringSecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInformation_ElectricitySupplyId",
                table: "GeneralInformation",
                column: "ElectricitySupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInformation_PremisesDescriptionId",
                table: "GeneralInformation",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Heatings_GeneralInformationId",
                table: "Heatings",
                column: "GeneralInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_LightingDevices_GeneralInformationId",
                table: "LightingDevices",
                column: "GeneralInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_NetworkCharacteristics_ElectricitySupplyId",
                table: "NetworkCharacteristics",
                column: "ElectricitySupplyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_RepairStatusId",
                table: "People",
                column: "RepairStatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_ResponsibilityForPremisesId",
                table: "People",
                column: "ResponsibilityForPremisesId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairStatuses_PremisesDescriptionId",
                table: "RepairStatuses",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibilityForPremises_PremisesDescriptionId",
                table: "ResponsibilityForPremises",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_PremisesDescriptionId",
                table: "Softwares",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Windows_GeneralInformationId",
                table: "Windows",
                column: "GeneralInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessibilityForPersonsWithDisabilities");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "FireExtinguishers");

            migrationBuilder.DropTable(
                name: "Heatings");

            migrationBuilder.DropTable(
                name: "LightingDevices");

            migrationBuilder.DropTable(
                name: "NetworkCharacteristics");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "Windows");

            migrationBuilder.DropTable(
                name: "EnsuringSecurities");

            migrationBuilder.DropTable(
                name: "RepairStatuses");

            migrationBuilder.DropTable(
                name: "ResponsibilityForPremises");

            migrationBuilder.DropTable(
                name: "GeneralInformation");

            migrationBuilder.DropTable(
                name: "ElectricitySupply");

            migrationBuilder.DropTable(
                name: "PremisesDescriptions");
        }
    }
}
