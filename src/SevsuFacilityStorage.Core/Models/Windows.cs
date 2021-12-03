using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Models
{
    public class Windows
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public int Quantity { get; set; }

        public string Direction { get; set; }

        public string Obstacles { get; set; }

        public double Area { get; set; }

        public string Grids { get; set; }
    }
}
