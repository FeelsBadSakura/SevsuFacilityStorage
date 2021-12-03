using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class Door
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public int Quantity { get; set; }

        public bool IsElectronicLock { get; set; }


    }
}
