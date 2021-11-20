﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SevsuFacilityStorage.Data;

namespace SevsuFacilityStorage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211120175844_AddRoles")]
    partial class AddRoles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.AccessibilityForPersonsWithDisabilities", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Availability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AvailabilityCharacteristics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PremisesDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PremisesDescriptionId")
                        .IsUnique();

                    b.ToTable("AccessibilityForPersonsWithDisabilities");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Door", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GeneralInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsElectronicLock")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralInformationId");

                    b.ToTable("Doors");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.ElectricitySupply", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeEnergizingDevice")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStandartSocket")
                        .HasColumnType("bit");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ElectricitySupply");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.EnsuringSecurity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasAutomaticNotificationSystem")
                        .HasColumnType("bit");

                    b.Property<bool>("HasSecurityAlarmSystem")
                        .HasColumnType("bit");

                    b.Property<Guid>("PremisesDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PremisesDescriptionId")
                        .IsUnique();

                    b.ToTable("EnsuringSecurities");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Equipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InventoryNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PremisesDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PremisesDescriptionId")
                        .IsUnique();

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.FireExtinguisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EnsuringSecurityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnsuringSecurityId");

                    b.ToTable("FireExtinguishers");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.GeneralInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<Guid?>("ElectricitySupplyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FloorCovering")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<Guid>("PremisesDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WallCovering")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ElectricitySupplyId");

                    b.HasIndex("PremisesDescriptionId")
                        .IsUnique();

                    b.ToTable("GeneralInformation");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Heating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GeneralInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralInformationId");

                    b.ToTable("Heatings");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.LightingDevice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GeneralInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralInformationId");

                    b.ToTable("LightingDevices");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.NetworkCharacteristics", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ElectricitySupplyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsFHDNetwork")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInternerAccess")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLVC")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRJ45Socket")
                        .HasColumnType("bit");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SocketsOccupied")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ElectricitySupplyId")
                        .IsUnique();

                    b.ToTable("NetworkCharacteristics");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RepairStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ResponsibilityForPremisesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RepairStatusId")
                        .IsUnique();

                    b.HasIndex("ResponsibilityForPremisesId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.PremisesDescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCurrentInformation")
                        .HasColumnType("datetime2");

                    b.Property<string>("InnerNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberByBTI")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PremisesDescriptions");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.RepairStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PlannedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PremisesDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("UnderRepair")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PremisesDescriptionId")
                        .IsUnique();

                    b.ToTable("RepairStatuses");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.ResponsibilityForPremises", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Basis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PremisesDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PremisesDescriptionId")
                        .IsUnique();

                    b.ToTable("ResponsibilityForPremises");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Software", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CharacteristicsOfPurchaseAgreement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PremisesDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PremisesDescriptionId")
                        .IsUnique();

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Windows", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GeneralInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Grids")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obstacles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneralInformationId");

                    b.ToTable("Windows");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.AccessibilityForPersonsWithDisabilities", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.PremisesDescription", "PremisesDescription")
                        .WithOne("AccessibilityForPersonsWithDisabilities")
                        .HasForeignKey("SevsuFacilityStorage.Models.AccessibilityForPersonsWithDisabilities", "PremisesDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremisesDescription");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Door", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.GeneralInformation", null)
                        .WithMany("Doors")
                        .HasForeignKey("GeneralInformationId");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.EnsuringSecurity", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.PremisesDescription", "PremisesDescription")
                        .WithOne("EnsuringSecurity")
                        .HasForeignKey("SevsuFacilityStorage.Models.EnsuringSecurity", "PremisesDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremisesDescription");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Equipment", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.PremisesDescription", "PremisesDescription")
                        .WithOne("Equipment")
                        .HasForeignKey("SevsuFacilityStorage.Models.Equipment", "PremisesDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremisesDescription");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.FireExtinguisher", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.EnsuringSecurity", "EnsuringSecurity")
                        .WithMany("FireExtinguishers")
                        .HasForeignKey("EnsuringSecurityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnsuringSecurity");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.GeneralInformation", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.ElectricitySupply", "ElectricitySupply")
                        .WithMany()
                        .HasForeignKey("ElectricitySupplyId");

                    b.HasOne("SevsuFacilityStorage.Models.PremisesDescription", "PremisesDescription")
                        .WithOne("GeneralInformation")
                        .HasForeignKey("SevsuFacilityStorage.Models.GeneralInformation", "PremisesDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricitySupply");

                    b.Navigation("PremisesDescription");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Heating", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.GeneralInformation", null)
                        .WithMany("Heatings")
                        .HasForeignKey("GeneralInformationId");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.LightingDevice", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.GeneralInformation", null)
                        .WithMany("LightingDevices")
                        .HasForeignKey("GeneralInformationId");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.NetworkCharacteristics", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.ElectricitySupply", "ElectricitySupply")
                        .WithOne("NetworkCharacteristics")
                        .HasForeignKey("SevsuFacilityStorage.Models.NetworkCharacteristics", "ElectricitySupplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricitySupply");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Person", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.RepairStatus", "RepairStatus")
                        .WithOne("Person")
                        .HasForeignKey("SevsuFacilityStorage.Models.Person", "RepairStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SevsuFacilityStorage.Models.ResponsibilityForPremises", "ResponsibilityForPremises")
                        .WithMany("ResponsiblePersons")
                        .HasForeignKey("ResponsibilityForPremisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RepairStatus");

                    b.Navigation("ResponsibilityForPremises");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.RepairStatus", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.PremisesDescription", "PremisesDescription")
                        .WithOne("RepairStatus")
                        .HasForeignKey("SevsuFacilityStorage.Models.RepairStatus", "PremisesDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremisesDescription");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.ResponsibilityForPremises", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.PremisesDescription", "PremisesDescription")
                        .WithOne("ResponsibilityForPremises")
                        .HasForeignKey("SevsuFacilityStorage.Models.ResponsibilityForPremises", "PremisesDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremisesDescription");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Software", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.PremisesDescription", "PremisesDescription")
                        .WithOne("Software")
                        .HasForeignKey("SevsuFacilityStorage.Models.Software", "PremisesDescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PremisesDescription");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.Windows", b =>
                {
                    b.HasOne("SevsuFacilityStorage.Models.GeneralInformation", null)
                        .WithMany("Windows")
                        .HasForeignKey("GeneralInformationId");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.ElectricitySupply", b =>
                {
                    b.Navigation("NetworkCharacteristics");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.EnsuringSecurity", b =>
                {
                    b.Navigation("FireExtinguishers");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.GeneralInformation", b =>
                {
                    b.Navigation("Doors");

                    b.Navigation("Heatings");

                    b.Navigation("LightingDevices");

                    b.Navigation("Windows");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.PremisesDescription", b =>
                {
                    b.Navigation("AccessibilityForPersonsWithDisabilities");

                    b.Navigation("EnsuringSecurity");

                    b.Navigation("Equipment");

                    b.Navigation("GeneralInformation");

                    b.Navigation("RepairStatus");

                    b.Navigation("ResponsibilityForPremises");

                    b.Navigation("Software");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.RepairStatus", b =>
                {
                    b.Navigation("Person");
                });

            modelBuilder.Entity("SevsuFacilityStorage.Models.ResponsibilityForPremises", b =>
                {
                    b.Navigation("ResponsiblePersons");
                });
#pragma warning restore 612, 618
        }
    }
}
