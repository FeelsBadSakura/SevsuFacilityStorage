using Microsoft.EntityFrameworkCore;
using SevsuFacilityStorage.Abstractions;
using SevsuFacilityStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Data
{
    public class PremiasesDescriptionRepository: IPremiasesDescriptionRepository
    {
        private readonly ApplicationDbContext _context;

        public PremiasesDescriptionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateRecord(PremiasesDescription premiasesDescription)
        {
            _context.Add(premiasesDescription);
            _context.SaveChanges();
        }

        public IEnumerable<PremiasesDescription> GetAllDescriptions()
        {
            return _context.PremiasesDescriptions
                .Include(PremiasesDescription => PremiasesDescription.AccessibilityForPersonsWithDisabilities)
                .Include(PremiasesDescription => PremiasesDescription.EnsuringSecurity)
                .Include(PremiasesDescription => PremiasesDescription.Equipment)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.heatings)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.lightingDevices)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.doors)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.windows)
                .Include(PremiasesDescription => PremiasesDescription.RepairStatus)
                    .ThenInclude(RepairStatus => RepairStatus.Person)
                .Include(PremiasesDescription => PremiasesDescription.Software)
                .Include(PremiasesDescription => PremiasesDescription.ResponsibilityForPremises)
                    .ThenInclude(ResponsibilityForPremises => ResponsibilityForPremises.ResponsiblePersons)
                .ToList();
        }

    }
}
