using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class AccessibilityForPersonsWithDisabilities
    {
        public Guid Id { get; set; }

        public string Availability { get; set; }

        public string AvailabilityCharacteristics { get; set; }

        public Guid PremiasesDescriptionId { get; set; }

        public PremiasesDescription PremiasesDescription { get; set; }

    }
}
