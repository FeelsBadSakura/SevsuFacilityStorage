using SevsuFacilityStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Core.Models
{
    public class PurposeOfPremises
    {
        public Guid Id { get; set; }
        public string Type { get; set; }

        public string Sort { get; set; }

        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }
    }
}
