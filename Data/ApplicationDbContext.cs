using Microsoft.EntityFrameworkCore;
using SevsuFacilityStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        
        public DbSet<AccessibilityForPersonsWithDisabilities> AccessibilityForPersonsWithDisabilities { get; set; }

        public DbSet<Door> Doors { get; set; }

        public DbSet<EnsuringSecurity> EnsuringSecurities { get; set; }

        public DbSet<Equipment> Equipment { get; set; }

        public DbSet<FireExtinguisher> FireExtinguishers { get; set; }
        public DbSet<GeneralInformation> GeneralInformation { get; set; }

        public DbSet<Heating> Heatings { get; set; }

        public DbSet<LightingDevice> LightingDevices { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<PremiasesDescription> PremiasesDescriptions { get; set; }

        public DbSet<RepairStatus> RepairStatuses { get; set; }

        public DbSet<ResponsibilityForPremises> ResponsibilityForPremises { get; set; }

        public DbSet<Software> Softwares { get; set; }

        public DbSet<Windows> Windows { get; set; }


    }
}
