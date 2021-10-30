using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class PremiasesDescription
    {
        public Guid Id { get; set; }

        public AccessibilityForPersonsWithDisabilities AccessibilityForPersonsWithDisabilities { get; set; }

        public EnsuringSecurity EnsuringSecurity { get; set; }

        public Equipment Equipment { get; set; }

        public GeneralInformation GeneralInformation { get; set; }

        public RepairStatus RepairStatus { get; set; }

        public ResponsibilityForPremises ResponsibilityForPremises { get; set; }

        public Software Software { get; set; }

    }
}
