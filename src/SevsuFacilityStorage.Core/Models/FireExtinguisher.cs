using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireExtinguisher
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public int quantity { get; set; }

        public Guid EnsuringSecurityId { get; set; }

        public EnsuringSecurity EnsuringSecurity { get; set; }
    }
}
