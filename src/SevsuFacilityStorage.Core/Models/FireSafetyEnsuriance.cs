using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireSafetyEnsuriance
    { 
        public Guid Id { get; set; }
        public int Floor { get; set; }
        public int PeopleNumberLimit { get; set; }
        public int DistanceToFloorExit { get; set; }
        public bool HasInstruction { get; set; }
        public bool ForeignerStayPossibillity { get; set; }
        public bool HasFireSafetyMaterials { get; set; }
        public ICollection<EmergencyExit> EmergencyExits { get; set; }
        public ICollection<LowMobilityPlace> LowMobilityPlaces { get; set; }

        public ICollection<FireSafetyMark> FireSafetyMarks { get; set; }
        public string FireSafetyMarkCategory { get; set; } //default value must be set to empty string
        public string FireSafetyMarkZoneClass { get; set; } //default value must be set to empty string

        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }
        public FireSafetyEnsurianceHardware FireSafetyEnsurianceHardware { get; set; }
        public FireSafetyMassPeoplePremise FireSafetyMassPeoplePremises { get; set; }
        public FireSafetyWareHouseOrProductionPremise FireSafetyWareHouseOrProductionPremises { get; set; }
    }
}
