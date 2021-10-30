﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SevsuFacilityStorage.Migrations
{
    public partial class Initialized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PremiasesDescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremiasesDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccessibilityForPersonsWithDisabilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailabilityCharacteristics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremiasesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibilityForPersonsWithDisabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessibilityForPersonsWithDisabilities_PremiasesDescriptions_PremiasesDescriptionId",
                        column: x => x.PremiasesDescriptionId,
                        principalTable: "PremiasesDescriptions",
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
                    PremiasesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnsuringSecurities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnsuringSecurities_PremiasesDescriptions_PremiasesDescriptionId",
                        column: x => x.PremiasesDescriptionId,
                        principalTable: "PremiasesDescriptions",
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
                    PremiasesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_PremiasesDescriptions_PremiasesDescriptionId",
                        column: x => x.PremiasesDescriptionId,
                        principalTable: "PremiasesDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    WallCovering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorCovering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremiasesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralInformation_PremiasesDescriptions_PremiasesDescriptionId",
                        column: x => x.PremiasesDescriptionId,
                        principalTable: "PremiasesDescriptions",
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
                    PremiasesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairStatuses_PremiasesDescriptions_PremiasesDescriptionId",
                        column: x => x.PremiasesDescriptionId,
                        principalTable: "PremiasesDescriptions",
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
                    PremiasesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibilityForPremises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsibilityForPremises_PremiasesDescriptions_PremiasesDescriptionId",
                        column: x => x.PremiasesDescriptionId,
                        principalTable: "PremiasesDescriptions",
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
                    PremiasesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Softwares_PremiasesDescriptions_PremiasesDescriptionId",
                        column: x => x.PremiasesDescriptionId,
                        principalTable: "PremiasesDescriptions",
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
                name: "IX_AccessibilityForPersonsWithDisabilities_PremiasesDescriptionId",
                table: "AccessibilityForPersonsWithDisabilities",
                column: "PremiasesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doors_GeneralInformationId",
                table: "Doors",
                column: "GeneralInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EnsuringSecurities_PremiasesDescriptionId",
                table: "EnsuringSecurities",
                column: "PremiasesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PremiasesDescriptionId",
                table: "Equipment",
                column: "PremiasesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FireExtinguishers_EnsuringSecurityId",
                table: "FireExtinguishers",
                column: "EnsuringSecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInformation_PremiasesDescriptionId",
                table: "GeneralInformation",
                column: "PremiasesDescriptionId",
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
                name: "IX_People_RepairStatusId",
                table: "People",
                column: "RepairStatusId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_ResponsibilityForPremisesId",
                table: "People",
                column: "ResponsibilityForPremisesId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairStatuses_PremiasesDescriptionId",
                table: "RepairStatuses",
                column: "PremiasesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibilityForPremises_PremiasesDescriptionId",
                table: "ResponsibilityForPremises",
                column: "PremiasesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Softwares_PremiasesDescriptionId",
                table: "Softwares",
                column: "PremiasesDescriptionId",
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
                name: "PremiasesDescriptions");
        }
    }
}
