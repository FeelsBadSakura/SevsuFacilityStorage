using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Core.Models
{
    public class AdditionalCharacteristics
    {
        public Guid PremisesId { get; set; }

        public Guid AdditionalId { get; set; }

        public string Type { get; set; }
    }
}
