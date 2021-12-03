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

        public int? StandartSocketQuantity { get; set; }

        public bool IsHighSocket { get; set; }

        public int? HighSocketQuantity { get; set; }

        public bool IsDeEnergizingDevice { get; set; }

        
    }
}
