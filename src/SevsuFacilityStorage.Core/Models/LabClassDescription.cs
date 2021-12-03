using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class LabClassDescription : AdditionalEducationalPremiseDescription
    {
        public string Type { get; set; }
        public string Purpose { get; set; }
    }
}
