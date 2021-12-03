using System;

namespace SevsuFacilityStorage.Models
{
    public class AdditionalEducationalPremiseDescription : PremisesDescription
    {
        public int AvailableSeatsQuantity { get; set; }
        public int TeacherJobsQuantity { get; set; }
        public bool HasBoard { get; set; }
        public string BoardType { get; set; }
        public bool HasStorage { get; set; }
        public bool HasTeachingAids { get; set; }
    }
}
