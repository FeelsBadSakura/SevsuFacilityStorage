﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class FireExtinguisher
    {
        public Guid Id { get; set; }

        public string Type { get; set; }
        public DateTime ManufactureDate { get; set; }

        public int Quantity { get; set; }

        public Guid FireSafetyEnsurianceHardwareId { get; set; }

        public FireSafetyEnsurianceHardware FireSafetyEnsurianceHardware { get; set; }

/*        public Guid EnsuringSecurityId { get; set; }

        public EnsuringSecurity EnsuringSecurity { get; set; }*/
    }
}
