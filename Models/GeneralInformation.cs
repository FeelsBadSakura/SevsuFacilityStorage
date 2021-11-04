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

        public double Height { get; set; }

        public string WallCovering { get; set; }

        public string FloorCovering { get; set; }

        public ICollection<Windows> Windows { get; set; }

        public ICollection<Door> Doors { get; set; }

        public ICollection<LightingDevice> LightingDevices { get; set; }

        public ElectricitySupply ElectricitySupply { get; set; }

        public ICollection<Heating> Heatings { get; set; }


        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }
    }
}
