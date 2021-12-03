using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<PremisesDescriptionMainViewModel> PremisesDescriptions { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
    }
}
