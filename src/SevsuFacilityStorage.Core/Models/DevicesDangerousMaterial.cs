using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class DevicesDangerousMaterial
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string UsageOrstorageMethod { get; set; }

        public Guid FireSafetyWareHouseOrProductionPremiseId { get; set; }
        public FireSafetyWareHouseOrProductionPremise FireSafetyWareHouseOrProductionPremise { get; set; }
    }
}
