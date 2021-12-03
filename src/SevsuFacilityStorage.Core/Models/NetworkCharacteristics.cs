using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class NetworkCharacteristics
    {
        public Guid Id { get; set; }

        public bool IsRJ45Socket { get; set; }

        public int? Quantity { get; set; }

        public int SocketsOccupied { get; set; }

        public bool IsLVC { get; set; }

        public bool IsFHDNetwork { get; set; }

        public bool IsInternerAccess { get; set; }


        public Guid ElectricitySupplyId { get; set; }
        public ElectricitySupply ElectricitySupply { get; set; }
    }
}
