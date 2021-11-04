using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class Software
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LicenseType { get; set; }

        public string CharacteristicsOfPurchaseAgreement { get; set; }


        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }

    }
}
