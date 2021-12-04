using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class EmergencyExit
    {
        public Guid Id { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public Guid FireSafetyEnsurianceId { get; set; }
        public FireSafetyEnsuriance FireSafetyEnsuriance { get; set; }
    }
}
