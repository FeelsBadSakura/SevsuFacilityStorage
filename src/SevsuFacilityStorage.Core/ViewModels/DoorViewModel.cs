using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Core.ViewModels
{
    public class DoorViewModel
    {
        public string Type { get; set; }

        public int Quantity { get; set; }

        public bool IsElectronicLock { get; set; }
    }
}
