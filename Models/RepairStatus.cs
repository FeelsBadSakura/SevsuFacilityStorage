using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class RepairStatus
    {
        public Guid Id { get; set; }

        public bool UnderRepair { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime PlannedEndDate { get; set; }


        public Person Person { get; set; }


        public Guid PremiasesDescriptionId { get; set; }
        public PremiasesDescription PremiasesDescription { get; set; }

    }
}
