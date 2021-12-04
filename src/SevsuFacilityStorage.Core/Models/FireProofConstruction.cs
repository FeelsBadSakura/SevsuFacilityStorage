using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireProofConstruction
    {
        public Guid Id { get; set; }
        public string ConstructionName { get; set; }
        public string Material { get; set; }
        public int TreatmentArea { get; set; }
        public DateTime TreatmentDate { get; set; }
        public Guid FireSafetyEnsurianceHardwareId { get; set; }
        public FireSafetyEnsurianceHardware FireSafetyEnsurianceHardware { get; set; }
    }
}
