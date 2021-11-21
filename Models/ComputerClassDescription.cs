using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class ComputerClassDescription : AdditionalEducationalPremiseDescription
    {
        public int PersonalComputersQuantity { get; set; }
        public string Type { get; set; }
    }
}
