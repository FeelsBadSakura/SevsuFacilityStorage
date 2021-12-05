using System;

namespace SevsuFacilityStorage.Models
{
    public class AdditionalEducationalPremiseDescription
    {
        public Guid Id { get; set; }
        public int AvailableSeatsQuantity { get; set; }
        public int TeacherJobsQuantity { get; set; }
        public bool HasBoard { get; set; }
        public string BoardType { get; set; }
        public bool HasStorage { get; set; }
        public bool HasTeachingAids { get; set; }

        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }
    }
}
