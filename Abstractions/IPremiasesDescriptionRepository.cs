using SevsuFacilityStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Abstractions
{
    public interface IPremiasesDescriptionRepository
    {
        public void CreateRecord(PremiasesDescription premiasesDescription);

        public IEnumerable<PremiasesDescription> GetAllDescriptions();

    }
}
