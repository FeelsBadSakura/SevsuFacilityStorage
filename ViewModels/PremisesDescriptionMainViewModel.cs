using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.ViewModels
{
    public class PremisesDescriptionMainViewModel
    {
        public string InnerNumber { set; get; }

        public string NumberByBTI { get; set; }

        public DateTime DateOfCurrentInformation { get; set; }

        public string Adress { get; set; }
    }
}
