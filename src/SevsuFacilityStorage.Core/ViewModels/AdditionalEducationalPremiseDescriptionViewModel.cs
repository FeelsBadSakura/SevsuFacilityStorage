using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Core.ViewModels
{
    public class AdditionalEducationalPremiseDescriptionViewModel
    {
        public int AvailableSeatsQuantity { get; set; }
        public int TeacherJobsQuantity { get; set; }
        public bool HasBoard { get; set; }
        public string BoardType { get; set; }
        public bool HasStorage { get; set; }
        public bool HasTeachingAids { get; set; }
    }
}
