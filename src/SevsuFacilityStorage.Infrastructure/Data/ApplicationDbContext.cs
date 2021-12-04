using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SevsuFacilityStorage.Core.Models;
using SevsuFacilityStorage.Infrastructure.Data.Mapping;
using SevsuFacilityStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Data
{
    public class ApplicationDbContext: IdentityDbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        
        public DbSet<AccessibilityForPersonsWithDisabilities> AccessibilityForPersonsWithDisabilities { get; set; }

        public DbSet<Door> Doors { get; set; }

        public DbSet<ElectricitySupply> ElectricitySupply { get; set; }

        //public DbSet<EnsuringSecurity> EnsuringSecurities { get; set; }

        public DbSet<Equipment> Equipment { get; set; }

        public DbSet<FireExtinguisher> FireExtinguishers { get; set; }
        public DbSet<GeneralInformation> GeneralInformation { get; set; }

        public DbSet<Heating> Heatings { get; set; }

        public DbSet<LightingDevice> LightingDevices { get; set; }

        public DbSet<NetworkCharacteristics> NetworkCharacteristics { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<PremisesDescription> PremisesDescriptions { get; set; }
        public DbSet<AdditionalAdministrativePremiseDescription> AdditionalAdministrativePremiseDescriptions { get; set; }
        public DbSet<AdditionalEducationalPremiseDescription> AdditionalEducationalPremiseDescriptions { get; set; }
        public DbSet<ComputerClassDescription> ComputerClasses { get; set; }
        public DbSet<LabClassDescription> LabClasses { get; set; }

        public DbSet<PurposeOfPremises> PurposeOfPremises { get; set; }

        public DbSet<AdditionalCharacteristics> AdditionalCharacteristics { get; set; }
        public DbSet<RepairStatus> RepairStatuses { get; set; }

        public DbSet<ResponsibilityForPremises> ResponsibilityForPremises { get; set; }

        public DbSet<Software> Softwares { get; set; }

        public DbSet<Windows> Windows { get; set; }
        public DbSet<FireSafetyEnsuriance> FireSafetyEnsuriances { get; set; }
        public DbSet<FireSafetyEnsurianceHardware> FireSafetyEnsurianceHardwares { get; set; }
        public DbSet<FireSafetyMassPeoplePremise> FireSafetyMassPeoplePremises { get; set; }
        public DbSet<FireSafetyWareHouseOrProductionPremise> FireSafetyWareHouseOrProductionPremises { get; set; }
        public DbSet<TechnicalreEquipmentDate> TechnicalreEquipmentDates { get; set; }
        public DbSet<VentilationSystem> VentilationSystems { get; set; }
        public DbSet<SurfaceFireDangerClass> SurfaceFireDangerClasses { get; set; }
        public DbSet<BurnableMaterial> BurnableMaterials { get; set; }
        public DbSet<LowMobilityPlace> LowMobilityPlaces { get; set; }
        public DbSet<GasAndSmokeProtectKit> GasAndSmokeProtectKits { get; set; }
        public DbSet<FireShield> FireShields { get; set; }
        public DbSet<FireSafetyTrapdoor> FireSafetyTrapdoors { get; set; }
        public DbSet<FireSafetyPlumbing> FireSafetyPlumbings { get; set; }
        public DbSet<FireSafetyMark> FireSafetyMarks { get; set; }
        public DbSet<FireSafetyDoor> FireSafetyDoors { get; set; }
        public DbSet<FireRetainingDevice> FireRetainingDevices { get; set; }
        public DbSet<FireProofConstruction> FireProofConstructions { get; set; }
        public DbSet<FireOrExplosiveDangerZone> FireOrExplosiveDangerZones { get; set; }
        public DbSet<FireFightingSystem> FireFightingSystems { get; set; }
        public DbSet<FireAlarm> FireAlarms { get; set; }
        public DbSet<ExplosiveProofEquipment> ExplosiveProofEquipments { get; set; }
        public DbSet<EmergencySystem> EmergencySystems { get; set; }
        public DbSet<EmergencyExit> EmergencyExits { get; set; }
        public DbSet<DevicesDangerousMaterial> DevicesDangerousMaterials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdditionalCharacterisicsMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole("admin"),
                new IdentityRole("user"),
                new IdentityRole("moderator"),
                new IdentityRole("responsible")
                );
        }

    }

}
