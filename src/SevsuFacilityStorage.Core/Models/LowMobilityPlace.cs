using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class LowMobilityPlace
    {
        public Guid Id { get; set; }
        public string Type { get; set; }//key?
        public int Quantity { get; set; }
        public Guid FireSafetyEnsurianceId { get; set; }
        public FireSafetyEnsuriance FireSafetyEnsuriance { get; set; }
    }
}
