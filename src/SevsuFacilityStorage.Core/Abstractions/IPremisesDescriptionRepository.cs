using SevsuFacilityStorage.Core.ViewModels;
using SevsuFacilityStorage.Models;
using SevsuFacilityStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Abstractions
{
    public interface IPremisesDescriptionRepository
    {
        public void CreateRecord(PremisesDescription premisesDescription);

        public void DeleteRecord(string number);

        public void EditRecord(PremisesDescription premisesDescription);

        public IEnumerable<PremisesDescription> GetAllDescriptions();

        public IEnumerable<PremisesDescription> GetMainInformation(FiltersViewModel filtersViewModel, int page, int pageSize);

        public PremisesDescription GetDescriptionByNumber(string number);

    }
}
