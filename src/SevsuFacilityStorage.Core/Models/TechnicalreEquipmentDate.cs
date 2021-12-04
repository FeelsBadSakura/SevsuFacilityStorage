using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class TechnicalreEquipmentDate
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public Guid FireSafetyMassPeoplePremiseId { get; set; }
        public FireSafetyMassPeoplePremise FireSafetyMassPeoplePremise { get; set; }
    }
}
