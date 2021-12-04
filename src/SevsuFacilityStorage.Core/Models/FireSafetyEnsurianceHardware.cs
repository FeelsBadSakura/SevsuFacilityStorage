using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireSafetyEnsurianceHardware
    {
        public Guid Id { get; set; }
        public Guid FireSafetyEnsurianceId { get; set; }
        public FireSafetyEnsuriance FireSafetyEnsuriance { get; set; }
        
        public ICollection<FireShield> FireShields { get; set; }
        public ICollection<GasAndSmokeProtectKit> GasAndSmokeProtectKits { get; set; }
        public ICollection<FireAlarm> FireAlarms { get; set; }
        public ICollection<EmergencySystem> EmergencySystems { get; set; }
        public ICollection<FireSafetyDoor> FireSafetyDoors { get; set; }
        public ICollection<FireSafetyTrapdoor> FireSafetyTrapdoors { get; set; }
        public ICollection<VentilationSystem> VentilationSystems { get; set; }
        public ICollection<FireFightingSystem> FireFightingSystems { get; set; }
        public ICollection<FireSafetyPlumbing> FireSafetyPlumbings { get; set; }
        public ICollection<FireExtinguisher> FireExtinguishers { get; set; }
        public ICollection<FireRetainingDevice> FireRetainingDevices { get; set; }
        public ICollection<FireProofConstruction> FireProofConstructions { get; set; }
        public string PlaceOfNearestFireExtinguisher { get; set; }
        public bool HasTelephone { get; set; }
    }
}
