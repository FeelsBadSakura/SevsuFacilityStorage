using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SevsuFacilityStorage.Infrastructure.Migrations
{
    public partial class FireSafety : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectricitySupply",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStandartSocket = table.Column<bool>(type: "bit", nullable: false),
                    StandartSocketQuantity = table.Column<int>(type: "int", nullable: true),
                    IsHighSocket = table.Column<bool>(type: "bit", nullable: false),
                    HighSocketQuantity = table.Column<int>(type: "int", nullable: true),
                    IsDeEnergizingDevice = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricitySupply", x => x.Id);
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
                    IsInternerAccess = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetworkCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PremisesDescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InnerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberByBTI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfCurrentInformation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HousingIndex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtractFromEGRN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Index = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremisesDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                name: "EnsuringSecurity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HasAutomaticNotificationSystem = table.Column<bool>(type: "bit", nullable: false),
                    HasSecurityAlarmSystem = table.Column<bool>(type: "bit", nullable: false),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnsuringSecurity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnsuringSecurity_PremisesDescriptions_PremisesDescriptionId",
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
                name: "FireSafetyEnsuriances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    PeopleNumberLimit = table.Column<int>(type: "int", nullable: false),
                    DistanceToFloorExit = table.Column<int>(type: "int", nullable: false),
                    HasInstruction = table.Column<bool>(type: "bit", nullable: false),
                    ForeignerStayPossibillity = table.Column<bool>(type: "bit", nullable: false),
                    HasFireSafetyMaterials = table.Column<bool>(type: "bit", nullable: false),
                    FireSafetyMarkCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyMarkZoneClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PremisesDescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireSafetyEnsuriances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireSafetyEnsuriances_PremisesDescriptions_PremisesDescriptionId",
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
                    CeilingCovering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricitySupplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NetworkCharacteristicsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_GeneralInformation_NetworkCharacteristics_NetworkCharacteristicsId",
                        column: x => x.NetworkCharacteristicsId,
                        principalTable: "NetworkCharacteristics",
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
                name: "EmergencyExits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    FireSafetyEnsurianceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyExits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyExits_FireSafetyEnsuriances_FireSafetyEnsurianceId",
                        column: x => x.FireSafetyEnsurianceId,
                        principalTable: "FireSafetyEnsuriances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireSafetyEnsurianceHardwares",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FireSafetyEnsurianceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlaceOfNearestFireExtinguisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasTelephone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireSafetyEnsurianceHardwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireSafetyEnsurianceHardwares_FireSafetyEnsuriances_FireSafetyEnsurianceId",
                        column: x => x.FireSafetyEnsurianceId,
                        principalTable: "FireSafetyEnsuriances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireSafetyMarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyEnsurianceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireSafetyMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireSafetyMarks_FireSafetyEnsuriances_FireSafetyEnsurianceId",
                        column: x => x.FireSafetyEnsurianceId,
                        principalTable: "FireSafetyEnsuriances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireSafetyMassPeoplePremises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FireSafetyEnsurianceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HasEmergencyPlan = table.Column<bool>(type: "bit", nullable: false),
                    HasEmergencyLighting = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireSafetyMassPeoplePremises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireSafetyMassPeoplePremises_FireSafetyEnsuriances_FireSafetyEnsurianceId",
                        column: x => x.FireSafetyEnsurianceId,
                        principalTable: "FireSafetyEnsuriances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireSafetyWareHouseOrProductionPremises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FireSafetyEnsurianceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FireOrExplosionHazardCategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireSafetyWareHouseOrProductionPremises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireSafetyWareHouseOrProductionPremises_FireSafetyEnsuriances_FireSafetyEnsurianceId",
                        column: x => x.FireSafetyEnsurianceId,
                        principalTable: "FireSafetyEnsuriances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LowMobilityPlaces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FireSafetyEnsurianceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LowMobilityPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LowMobilityPlaces_FireSafetyEnsuriances_FireSafetyEnsurianceId",
                        column: x => x.FireSafetyEnsurianceId,
                        principalTable: "FireSafetyEnsuriances",
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
                    Area = table.Column<double>(type: "float", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EmergencySystems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencySystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencySystems_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireAlarms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireAlarms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireAlarms_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireExtinguishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnsuringSecurityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireExtinguishers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireExtinguishers_EnsuringSecurity_EnsuringSecurityId",
                        column: x => x.EnsuringSecurityId,
                        principalTable: "EnsuringSecurity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FireExtinguishers_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireFightingSystems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireFightingSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireFightingSystems_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireProofConstructions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConstructionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreatmentArea = table.Column<int>(type: "int", nullable: false),
                    TreatmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireProofConstructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireProofConstructions_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireRetainingDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireRetainingDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireRetainingDevices_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireSafetyDoors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireSafetyDoors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireSafetyDoors_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireSafetyPlumbings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsStaffed = table.Column<bool>(type: "bit", nullable: false),
                    IsWorkable = table.Column<bool>(type: "bit", nullable: false),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireSafetyPlumbings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireSafetyPlumbings_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireSafetyTrapdoors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireSafetyTrapdoors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireSafetyTrapdoors_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireShields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complectation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireShields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireShields_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GasAndSmokeProtectKits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasAndSmokeProtectKits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GasAndSmokeProtectKits_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VentilationSystems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyEnsurianceHardwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentilationSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentilationSystems_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceHardwareId",
                        column: x => x.FireSafetyEnsurianceHardwareId,
                        principalTable: "FireSafetyEnsurianceHardwares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurfaceFireDangerClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurfaceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfaceClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurfaceLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyMassPeoplePremiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurfaceFireDangerClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurfaceFireDangerClasses_FireSafetyMassPeoplePremises_FireSafetyMassPeoplePremiseId",
                        column: x => x.FireSafetyMassPeoplePremiseId,
                        principalTable: "FireSafetyMassPeoplePremises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalreEquipmentDates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FireSafetyMassPeoplePremiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalreEquipmentDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnicalreEquipmentDates_FireSafetyMassPeoplePremises_FireSafetyMassPeoplePremiseId",
                        column: x => x.FireSafetyMassPeoplePremiseId,
                        principalTable: "FireSafetyMassPeoplePremises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BurnableMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityKG = table.Column<int>(type: "int", nullable: false),
                    UsageOrstorageMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageArea = table.Column<int>(type: "int", nullable: false),
                    FireSafetyWareHouseOrProductionPremiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurnableMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BurnableMaterials_FireSafetyWareHouseOrProductionPremises_FireSafetyWareHouseOrProductionPremiseId",
                        column: x => x.FireSafetyWareHouseOrProductionPremiseId,
                        principalTable: "FireSafetyWareHouseOrProductionPremises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DevicesDangerousMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UsageOrstorageMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyWareHouseOrProductionPremiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicesDangerousMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevicesDangerousMaterials_FireSafetyWareHouseOrProductionPremises_FireSafetyWareHouseOrProductionPremiseId",
                        column: x => x.FireSafetyWareHouseOrProductionPremiseId,
                        principalTable: "FireSafetyWareHouseOrProductionPremises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExplosiveProofEquipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplosiveProofClassLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplosiveProofClassType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationAccessabilityInZoneClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemperatureClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireSafetyWareHouseOrProductionPremiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExplosiveProofEquipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExplosiveProofEquipments_FireSafetyWareHouseOrProductionPremises_FireSafetyWareHouseOrProductionPremiseId",
                        column: x => x.FireSafetyWareHouseOrProductionPremiseId,
                        principalTable: "FireSafetyWareHouseOrProductionPremises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireOrExplosiveDangerZones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<int>(type: "int", nullable: false),
                    FireSafetyWareHouseOrProductionPremiseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireOrExplosiveDangerZones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FireOrExplosiveDangerZones_FireSafetyWareHouseOrProductionPremises_FireSafetyWareHouseOrProductionPremiseId",
                        column: x => x.FireSafetyWareHouseOrProductionPremiseId,
                        principalTable: "FireSafetyWareHouseOrProductionPremises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c5d6ac00-7fbd-41f4-a31a-e5113b9603e5", "b14ee58d-9035-4467-8913-4cb94ea02a41", "admin", null },
                    { "df29c721-f268-41d5-b45f-cfee7d072e56", "92609d5b-ff78-45ac-9912-ce17c7ee0ac2", "user", null },
                    { "21b66b51-f722-4968-802f-b8c8a53ca0e8", "f02aa115-2518-499c-aadb-c62d0f7b9c3e", "moderator", null },
                    { "7dde465c-2ea7-4220-9716-a81c856b2037", "6c39e1a6-92da-48ed-a5c4-2bddcbd68517", "responsible", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessibilityForPersonsWithDisabilities_PremisesDescriptionId",
                table: "AccessibilityForPersonsWithDisabilities",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BurnableMaterials_FireSafetyWareHouseOrProductionPremiseId",
                table: "BurnableMaterials",
                column: "FireSafetyWareHouseOrProductionPremiseId");

            migrationBuilder.CreateIndex(
                name: "IX_DevicesDangerousMaterials_FireSafetyWareHouseOrProductionPremiseId",
                table: "DevicesDangerousMaterials",
                column: "FireSafetyWareHouseOrProductionPremiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Doors_GeneralInformationId",
                table: "Doors",
                column: "GeneralInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyExits_FireSafetyEnsurianceId",
                table: "EmergencyExits",
                column: "FireSafetyEnsurianceId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencySystems_FireSafetyEnsurianceHardwareId",
                table: "EmergencySystems",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_EnsuringSecurity_PremisesDescriptionId",
                table: "EnsuringSecurity",
                column: "PremisesDescriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PremisesDescriptionId",
                table: "Equipment",
                column: "PremisesDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplosiveProofEquipments_FireSafetyWareHouseOrProductionPremiseId",
                table: "ExplosiveProofEquipments",
                column: "FireSafetyWareHouseOrProductionPremiseId");

            migrationBuilder.CreateIndex(
                name: "IX_FireAlarms_FireSafetyEnsurianceHardwareId",
                table: "FireAlarms",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FireExtinguishers_EnsuringSecurityId",
                table: "FireExtinguishers",
                column: "EnsuringSecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_FireExtinguishers_FireSafetyEnsurianceHardwareId",
                table: "FireExtinguishers",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FireFightingSystems_FireSafetyEnsurianceHardwareId",
                table: "FireFightingSystems",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FireOrExplosiveDangerZones_FireSafetyWareHouseOrProductionPremiseId",
                table: "FireOrExplosiveDangerZones",
                column: "FireSafetyWareHouseOrProductionPremiseId");

            migrationBuilder.CreateIndex(
                name: "IX_FireProofConstructions_FireSafetyEnsurianceHardwareId",
                table: "FireProofConstructions",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FireRetainingDevices_FireSafetyEnsurianceHardwareId",
                table: "FireRetainingDevices",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FireSafetyDoors_FireSafetyEnsurianceHardwareId",
                table: "FireSafetyDoors",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FireSafetyEnsurianceHardwares_FireSafetyEnsurianceId",
                table: "FireSafetyEnsurianceHardwares",
                column: "FireSafetyEnsurianceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FireSafetyEnsuriances_PremisesDescriptionId",
                table: "FireSafetyEnsuriances",
                column: "PremisesDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_FireSafetyMarks_FireSafetyEnsurianceId",
                table: "FireSafetyMarks",
                column: "FireSafetyEnsurianceId");

            migrationBuilder.CreateIndex(
                name: "IX_FireSafetyMassPeoplePremises_FireSafetyEnsurianceId",
                table: "FireSafetyMassPeoplePremises",
                column: "FireSafetyEnsurianceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FireSafetyPlumbings_FireSafetyEnsurianceHardwareId",
                table: "FireSafetyPlumbings",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FireSafetyTrapdoors_FireSafetyEnsurianceHardwareId",
                table: "FireSafetyTrapdoors",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_FireSafetyWareHouseOrProductionPremises_FireSafetyEnsurianceId",
                table: "FireSafetyWareHouseOrProductionPremises",
                column: "FireSafetyEnsurianceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FireShields_FireSafetyEnsurianceHardwareId",
                table: "FireShields",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_GasAndSmokeProtectKits_FireSafetyEnsurianceHardwareId",
                table: "GasAndSmokeProtectKits",
                column: "FireSafetyEnsurianceHardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInformation_ElectricitySupplyId",
                table: "GeneralInformation",
                column: "ElectricitySupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInformation_NetworkCharacteristicsId",
                table: "GeneralInformation",
                column: "NetworkCharacteristicsId");

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
                name: "IX_LowMobilityPlaces_FireSafetyEnsurianceId",
                table: "LowMobilityPlaces",
                column: "FireSafetyEnsurianceId");

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
                name: "IX_PurposeOfPremises_PremisesDescriptionId",
                table: "PurposeOfPremises",
                column: "PremisesDescriptionId",
                unique: true);

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
                column: "PremisesDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_SurfaceFireDangerClasses_FireSafetyMassPeoplePremiseId",
                table: "SurfaceFireDangerClasses",
                column: "FireSafetyMassPeoplePremiseId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalreEquipmentDates_FireSafetyMassPeoplePremiseId",
                table: "TechnicalreEquipmentDates",
                column: "FireSafetyMassPeoplePremiseId");

            migrationBuilder.CreateIndex(
                name: "IX_VentilationSystems_FireSafetyEnsurianceHardwareId",
                table: "VentilationSystems",
                column: "FireSafetyEnsurianceHardwareId");

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
                name: "AdditionalAdministrativePremiseDescriptions");

            migrationBuilder.DropTable(
                name: "AdditionalCharacteristics");

            migrationBuilder.DropTable(
                name: "AdditionalEducationalPremiseDescriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BurnableMaterials");

            migrationBuilder.DropTable(
                name: "DevicesDangerousMaterials");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "EmergencyExits");

            migrationBuilder.DropTable(
                name: "EmergencySystems");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "ExplosiveProofEquipments");

            migrationBuilder.DropTable(
                name: "FireAlarms");

            migrationBuilder.DropTable(
                name: "FireExtinguishers");

            migrationBuilder.DropTable(
                name: "FireFightingSystems");

            migrationBuilder.DropTable(
                name: "FireOrExplosiveDangerZones");

            migrationBuilder.DropTable(
                name: "FireProofConstructions");

            migrationBuilder.DropTable(
                name: "FireRetainingDevices");

            migrationBuilder.DropTable(
                name: "FireSafetyDoors");

            migrationBuilder.DropTable(
                name: "FireSafetyMarks");

            migrationBuilder.DropTable(
                name: "FireSafetyPlumbings");

            migrationBuilder.DropTable(
                name: "FireSafetyTrapdoors");

            migrationBuilder.DropTable(
                name: "FireShields");

            migrationBuilder.DropTable(
                name: "GasAndSmokeProtectKits");

            migrationBuilder.DropTable(
                name: "Heatings");

            migrationBuilder.DropTable(
                name: "LightingDevices");

            migrationBuilder.DropTable(
                name: "LowMobilityPlaces");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "PurposeOfPremises");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "SurfaceFireDangerClasses");

            migrationBuilder.DropTable(
                name: "TechnicalreEquipmentDates");

            migrationBuilder.DropTable(
                name: "VentilationSystems");

            migrationBuilder.DropTable(
                name: "Windows");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "EnsuringSecurity");

            migrationBuilder.DropTable(
                name: "FireSafetyWareHouseOrProductionPremises");

            migrationBuilder.DropTable(
                name: "RepairStatuses");

            migrationBuilder.DropTable(
                name: "ResponsibilityForPremises");

            migrationBuilder.DropTable(
                name: "FireSafetyMassPeoplePremises");

            migrationBuilder.DropTable(
                name: "FireSafetyEnsurianceHardwares");

            migrationBuilder.DropTable(
                name: "GeneralInformation");

            migrationBuilder.DropTable(
                name: "FireSafetyEnsuriances");

            migrationBuilder.DropTable(
                name: "ElectricitySupply");

            migrationBuilder.DropTable(
                name: "NetworkCharacteristics");

            migrationBuilder.DropTable(
                name: "PremisesDescriptions");
        }
    }
}
