using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class LabClassDescription
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Purpose { get; set; }

        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }
    }
}
