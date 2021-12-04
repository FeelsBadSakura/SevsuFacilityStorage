using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireSafetyWareHouseOrProductionPremise
    {
        public Guid Id { get; set; }
        public Guid FireSafetyEnsurianceId { get; set; }
        public ICollection<DevicesDangerousMaterial> DangerousMaterials { get; set; }
        public ICollection<BurnableMaterial> BurnableMaterials { get; set; }
        public string FireOrExplosionHazardCategory { get; set; }
        public ICollection<FireOrExplosiveDangerZone> FireOrExplosiveDangerZones { get; set; }
        public ICollection<ExplosiveProofEquipment> ExplosiveProofEquipments { get; set; }

        public FireSafetyEnsuriance FireSafetyEnsuriance { get; set; }
    }
}
