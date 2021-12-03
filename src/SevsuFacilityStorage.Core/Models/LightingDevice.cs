using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class LightingDevice
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public int Quantity { get; set; }

    }
}
