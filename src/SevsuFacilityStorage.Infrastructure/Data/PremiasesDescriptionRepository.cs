using Microsoft.EntityFrameworkCore;
using SevsuFacilityStorage.Abstractions;
using SevsuFacilityStorage.Models;
using SevsuFacilityStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Data
{
    public class PremiasesDescriptionRepository: IPremisesDescriptionRepository
    {
        private readonly ApplicationDbContext _context;

        public PremiasesDescriptionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateRecord(PremisesDescription premiasesDescription)
        {
            _context.Add(premiasesDescription);
            _context.SaveChanges();
        }

        public void DeleteRecord(string number)
        {
            _context.PremisesDescriptions.Remove(
                _context.PremisesDescriptions.FirstOrDefault(PremisesDescription => PremisesDescription.InnerNumber == number));
            _context.SaveChanges();
        }

        public void EditRecord(PremisesDescription premisesDescription)
        {
            _context.PremisesDescriptions.Update(premisesDescription);
            _context.SaveChanges();
        }

        public IEnumerable<PremisesDescription> GetAllDescriptions()
        {
            return _context.PremisesDescriptions
                .Include(PremiasesDescription => PremiasesDescription.AccessibilityForPersonsWithDisabilities)
                .Include(PremiasesDescription => PremiasesDescription.EnsuringSecurity)
                .Include(PremiasesDescription => PremiasesDescription.Equipments)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.Heatings)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.LightingDevices)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.Doors)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.Windows)
                .Include(PremiasesDescription => PremiasesDescription.RepairStatus)
                    .ThenInclude(RepairStatus => RepairStatus.Person)
                .Include(PremiasesDescription => PremiasesDescription.Softwares)
                .Include(PremiasesDescription => PremiasesDescription.ResponsibilityForPremises)
                    .ThenInclude(ResponsibilityForPremises => ResponsibilityForPremises.ResponsiblePersons)
                .ToList();
        }

        public PremisesDescription GetDescriptionByNumber(string number)
        {
            return _context.PremisesDescriptions
                .Include(PremiasesDescription => PremiasesDescription.AccessibilityForPersonsWithDisabilities)
                .Include(PremiasesDescription => PremiasesDescription.EnsuringSecurity)
                .Include(PremiasesDescription => PremiasesDescription.Equipments)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.Heatings)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.LightingDevices)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.Doors)
                .Include(PremiasesDescription => PremiasesDescription.GeneralInformation)
                    .ThenInclude(GeneralInformation => GeneralInformation.Windows)
                .Include(PremiasesDescription => PremiasesDescription.RepairStatus)
                    .ThenInclude(RepairStatus => RepairStatus.Person)
                .Include(PremiasesDescription => PremiasesDescription.Softwares)
                .Include(PremiasesDescription => PremiasesDescription.ResponsibilityForPremises)
                    .ThenInclude(ResponsibilityForPremises => ResponsibilityForPremises.ResponsiblePersons)
                .FirstOrDefault(model => model.InnerNumber == number);
        }

        public IEnumerable<PremisesDescription> GetMainInformation()
        {
            return _context.PremisesDescriptions
                .Include(PremiasesDescription => PremiasesDescription.ResponsibilityForPremises)
                .Include(PremiasesDescription => PremiasesDescription.PurposeOfPremises)
                .Include(PremiasesDescription => PremiasesDescription.AccessibilityForPersonsWithDisabilities)
                .Include(PremiasesDescription => PremiasesDescription.RepairStatus)
                .ToList();
        }

    }
}
