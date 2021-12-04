using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class BurnableMaterial
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int QuantityKG { get; set; }
        public string UsageOrstorageMethod { get; set; }
        public int StorageArea { get; set; }
        public Guid FireSafetyWareHouseOrProductionPremiseId { get; set; }
        public FireSafetyWareHouseOrProductionPremise FireSafetyWareHouseOrProductionPremise { get; set; }
    }
}
