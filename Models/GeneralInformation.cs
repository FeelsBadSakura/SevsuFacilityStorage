using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class GeneralInformation
    {
        public Guid Id { get; set; }

        public double Area { get; set; }

        public string WallCovering { get; set; }

        public string FloorCovering { get; set; }

        public ICollection<Windows> windows { get; set; }

        public ICollection<Door> doors { get; set; }

        public ICollection<LightingDevice> lightingDevices { get; set; }

        public ICollection<Heating> heatings { get; set; }


        public Guid PremiasesDescriptionId { get; set; }
        public PremiasesDescription PremiasesDescription { get; set; }
    }
}
