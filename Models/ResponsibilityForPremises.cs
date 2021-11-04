using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class ResponsibilityForPremises
    {
        public Guid Id { get; set; }
        public string Division { get; set; }

        public string Basis { get; set; }


        public ICollection<Person> ResponsiblePersons { get; set; }

        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }
    }
}
