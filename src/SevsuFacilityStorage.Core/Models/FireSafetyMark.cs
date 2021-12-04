using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireSafetyMark
    {
        public Guid Id { get; set; }
        public string Type { get; set; } //key?
        public Guid FireSafetyEnsurianceId { get; set; }
        public FireSafetyEnsuriance FireSafetyEnsuriance { get; set; }
    }
}
