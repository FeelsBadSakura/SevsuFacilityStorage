using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireOrExplosiveDangerZone
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public int Class { get; set; }
        public Guid FireSafetyWareHouseOrProductionPremiseId { get; set; }
        public FireSafetyWareHouseOrProductionPremise FireSafetyWareHouseOrProductionPremise { get; set; }
    }
}
