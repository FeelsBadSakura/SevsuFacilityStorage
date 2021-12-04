using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Core.ViewModels
{
    public class EquipmentViewModel
    {
        public string Type { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string InventoryNumber { get; set; }
    }
}
