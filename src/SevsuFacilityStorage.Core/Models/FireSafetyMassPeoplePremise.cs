using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireSafetyMassPeoplePremise
    {
        public Guid Id { get; set; }
        public Guid FireSafetyEnsurianceId { get; set; }
        public FireSafetyEnsuriance FireSafetyEnsuriance { get; set; }
        public ICollection<TechnicalreEquipmentDate> TechnicalEquipmentDates { get; set; }
        public ICollection<SurfaceFireDangerClass> SurfaceFireDangerClasses { get; set; }
        public bool HasEmergencyPlan { get; set; }
        public bool HasEmergencyLighting { get; set; }

    }
}
