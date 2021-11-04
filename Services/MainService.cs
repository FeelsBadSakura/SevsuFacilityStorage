using SevsuFacilityStorage.Abstractions;
using SevsuFacilityStorage.Models;
using SevsuFacilityStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Service
{
    public class MainService
    {
        private readonly IPremisesDescriptionRepository _premisesDescriptionRepository;
        
        public MainService(IPremisesDescriptionRepository premisesDescriptionRepository)
        {
            _premisesDescriptionRepository = premisesDescriptionRepository;
        }

        public void CreateDescription(PremisesDescriptionViewModel model)
        {
            PremisesDescription premisesDescription = new PremisesDescription
            {
                InnerNumber = model.InnerNumber,
                NumberByBTI = model.NumberByBTI,
               // DateOfCurrentInformation = model.DateOfCurrentInformation,
                Adress = model.Adress
            };
            _premisesDescriptionRepository.CreateRecord(premisesDescription);
        }

        public IEnumerable<PremisesDescriptionMainViewModel> GetMainInformation()
        {
            return _premisesDescriptionRepository.GetMainInformation()
                .Select(information => new PremisesDescriptionMainViewModel
                {
                    InnerNumber = information.InnerNumber,
                    NumberByBTI = information.NumberByBTI,
                    Adress = information.Adress,
                    //DateOfCurrentInformation = information.DateOfCurrentInformation
                });

        }


        public PremisesDescriptionViewModel GetDescriptionByNumber(string number)
        {
            var premisesDescription = _premisesDescriptionRepository.GetDescriptionByNumber(number);

            return new PremisesDescriptionViewModel
            {
                InnerNumber = premisesDescription.InnerNumber,
                NumberByBTI = premisesDescription.NumberByBTI,
                Adress = premisesDescription.Adress,
                //DateOfCurrentInformation = premisesDescription.DateOfCurrentInformation
            };

        }

       
    }
}
