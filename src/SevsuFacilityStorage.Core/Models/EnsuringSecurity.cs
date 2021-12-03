using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class EnsuringSecurity
    {
        public Guid Id { get; set; }

        public ICollection<FireExtinguisher> FireExtinguishers { get; set; }

        public bool HasAutomaticNotificationSystem { get; set; }

        public bool HasSecurityAlarmSystem { get; set; }


        public Guid PremisesDescriptionId { get; set; }

        public PremisesDescription PremisesDescription { get; set; }
    }
}
