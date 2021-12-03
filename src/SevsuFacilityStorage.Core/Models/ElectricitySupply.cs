using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class ElectricitySupply
    {
        public Guid Id { get; set; }

        public bool IsStandartSocket { get; set; }

        public int? Quantity { get; set; }

        public bool IsDeEnergizingDevice { get; set; }

        public NetworkCharacteristics NetworkCharacteristics { get; set; }
    }
}
