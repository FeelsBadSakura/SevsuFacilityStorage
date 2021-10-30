using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class Person
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Guid ResponsibilityForPremisesId { get; set; }
        public ResponsibilityForPremises ResponsibilityForPremises { get; set; }

        public Guid RepairStatusId { get; set; }

        public RepairStatus RepairStatus { get; set; }

    }
}
