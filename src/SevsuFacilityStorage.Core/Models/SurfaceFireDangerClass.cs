using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class SurfaceFireDangerClass
    {
        public Guid Id { get; set; }
        public string SurfaceType { get; set; }
        public string SurfaceClass { get; set; }
        public string SurfaceLocation { get; set; }

        public Guid FireSafetyMassPeoplePremiseId { get; set; }
        public FireSafetyMassPeoplePremise FireSafetyMassPeoplePremise { get; set; }
    }
}
