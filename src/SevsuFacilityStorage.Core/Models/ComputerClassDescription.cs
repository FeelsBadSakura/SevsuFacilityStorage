using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class ComputerClassDescription
    {
        public Guid Id { get; set; }
        public int PersonalComputersQuantity { get; set; }
        public string Type { get; set; }

        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }
    }
}
