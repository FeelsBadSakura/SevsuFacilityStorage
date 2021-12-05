using System;
namespace SevsuFacilityStorage.Models
{
    public class AdditionalAdministrativePremiseDescription
    {
        public Guid Id { get; set; }
        public int AllowedJobsQuantity { get; set; } //TODO: add default value calc-ed by divison of "area" and 4,5
        //or maybe some bad-response implemented by trigger on non-normative value input
        public int FilledfJobsQuantity { get; set; }

        public Guid PremisesDescriptionId { get; set; }
        public PremisesDescription PremisesDescription { get; set; }
    }
}
