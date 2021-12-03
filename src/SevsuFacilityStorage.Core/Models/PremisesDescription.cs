using SevsuFacilityStorage.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class PremisesDescription
    {
        public Guid Id { get; set; }

        public string InnerNumber { set; get; }

        public string NumberByBTI { get; set; }

        public DateTime DateOfCurrentInformation { get; set; }

        public string HousingIndex { get; set; }

        public string ExtractFromEGRN { get; set; }

        public string Index { get; set; }

        public int Floor { get; set; }

        public string AdditionalInfo { get; set; }

        public string Name { get; set; }

        public AccessibilityForPersonsWithDisabilities AccessibilityForPersonsWithDisabilities { get; set; }

        public EnsuringSecurity EnsuringSecurity { get; set; }

        public ICollection<Equipment> Equipments { get; set; }

        public GeneralInformation GeneralInformation { get; set; }

        public RepairStatus RepairStatus { get; set; }

        public ResponsibilityForPremises ResponsibilityForPremises { get; set; }

        public ICollection<Software> Softwares { get; set; }

        public PurposeOfPremises PurposeOfPremises { get; set; }

    }
}
