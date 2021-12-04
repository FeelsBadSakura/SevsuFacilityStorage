using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class ExplosiveProofEquipment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ExplosiveProofClassLevel { get; set; }
        public string ExplosiveProofClassType { get; set; }
        public string ApplicationAccessabilityInZoneClass { get; set; }
        public string TemperatureClass { get; set; }
        public Guid FireSafetyWareHouseOrProductionPremiseId { get; set; }
        public FireSafetyWareHouseOrProductionPremise FireSafetyWareHouseOrProductionPremise { get; set; }
    }
}
