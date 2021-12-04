using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Core.ViewModels
{
    public class WindowViewModel
    {
        public string Type { get; set; }

        public int Quantity { get; set; }

        public string Direction { get; set; }

        public string Obstacles { get; set; }

        public double Area { get; set; }

        public string Grids { get; set; }
    }
}
