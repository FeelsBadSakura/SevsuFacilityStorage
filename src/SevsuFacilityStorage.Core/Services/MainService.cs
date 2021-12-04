using SevsuFacilityStorage.Abstractions;
using SevsuFacilityStorage.Core.Models;
using SevsuFacilityStorage.Core.ViewModels;
using SevsuFacilityStorage.Models;
using SevsuFacilityStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Core.Service
{
    public class MainService
    {
        private readonly IPremisesDescriptionRepository _premisesDescriptionRepository;
        
        public MainService(IPremisesDescriptionRepository premisesDescriptionRepository)
        {
            _premisesDescriptionRepository = premisesDescriptionRepository;
        }

        public void CreateDescription(CreatePremisesDescriptionViewModel model)
        {

            ICollection<Windows> windows = new List<Windows>();
            foreach (var window in model.WindowViewModels)
            {
                windows.Add(new Windows
                {
                    Type = window.Type,
                    Quantity = window.Quantity,
                    Direction = window.Direction,
                    Obstacles = window.Obstacles,
                    Area = window.Area,
                    Grids = window.Grids
                });
            }

            ICollection<Door> doors = new List<Door>();
            foreach (var door in model.DoorViewModels)
            {
                doors.Add(new Door
                {
                    Type = door.Type,
                    Quantity = door.Quantity,
                    IsElectronicLock = door.IsElectronicLock
                });
            }

            ICollection<LightingDevice> lightingDevices = new List<LightingDevice>();
            foreach (var lightingDevice in model.LightningDeviceViewModels)
            {
                lightingDevices.Add(new LightingDevice
                {
                    Type = lightingDevice.Type,
                    Quantity = lightingDevice.Quantity
                });
            }

            ICollection<Heating> heatings = new List<Heating>();
            foreach (var heating in model.HeatingViewModels)
            {
                heatings.Add(new Heating
                {
                    Type = heating.Type,
                    Quantity = heating.Quantity
                });
            }

            ICollection<Equipment> equipments = new List<Equipment>();
            foreach (var equipment in model.EquipmentViewModels)
            {
                equipments.Add(new Equipment
                {
                    Type = equipment.Type,
                    Quantity = equipment.Quantity,
                    Name = equipment.Name,
                    Description = equipment.Description,
                    InventoryNumber = equipment.InventoryNumber
                });
            }

            ICollection<Software> softwares = new List<Software>();
            foreach (var software in model.SoftwareViewModels)
            {
                softwares.Add(new Software
                {
                    Name = software.Name,
                    Description = software.Description,
                    LicenseType = software.LicenseType
                });
            }



            PremisesDescription premisesDescription = new PremisesDescription
            {
                InnerNumber = model.InnerNumber,
                NumberByBTI = model.NumberByBTI,
                DateOfCurrentInformation = model.DateOfCurrentInformation,
                HousingIndex = model.HousingIndex,
                ExtractFromEGRN = model.ExtractFromEGRN,
                Index = model.Index,
                Floor = model.Floor,
                AdditionalInfo = model.AdditionalInfo,
                Name = model.Name,
                ResponsibilityForPremises = new ResponsibilityForPremises
                {
                    Division = model.Division,
                    Basis = model.Basis
                },
                PurposeOfPremises = new PurposeOfPremises
                {
                    Type = model.Type,
                    Sort = model.Sort
                },
                GeneralInformation = new GeneralInformation
                {
                    Area = model.Area,
                    Height = model.Height,
                    WallCovering = model.WallCovering,
                    FloorCovering = model.FloorCovering,
                    CeilingCovering = model.CeilingCovering,
                    Windows = windows,
                    Doors = doors,
                    LightingDevices = lightingDevices,
                    ElectricitySupply = new ElectricitySupply
                    {
                        IsStandartSocket = model.IsStandartSocket,
                        StandartSocketQuantity = model.StandartSocketQuantity,
                        IsHighSocket = model.IsHighSocket,
                        HighSocketQuantity = model.HighSocketQuantity,
                        IsDeEnergizingDevice = model.IsDeEnergizingDevice
                    },
                    NetworkCharacteristics = new NetworkCharacteristics
                    {
                        IsRJ45Socket = model.IsRJ45Socket,
                        Quantity = model.QuantityRJ45Socket,
                        SocketsOccupied = model.SocketsOccupied,
                        IsLVC = model.IsLVC,
                        IsFHDNetwork = model.IsFHDNetwork,
                        IsInternerAccess = model.IsInternerAccess
                    },
                    Heatings = heatings,
                },
                



                Equipments = equipments,
                Softwares = softwares,
                AccessibilityForPersonsWithDisabilities = new AccessibilityForPersonsWithDisabilities
                {
                    Availability = model.Availability,
                    AvailabilityCharacteristics = model.AvailabilityCharacteristics
                },




                RepairStatus = new RepairStatus
                {
                    UnderRepair = model.UnderRepair,
                    StartDate = model.StartRepairDate,
                    PlannedEndDate = model.PlannedEndRepairDate
                }
            };
            _premisesDescriptionRepository.CreateRecord(premisesDescription);
        }

        public void DeleteDescription(string number)
        {
            _premisesDescriptionRepository.DeleteRecord(number);
        }

        public void EditDescription(PremisesDescriptionEditViewModel model)
        {
            PremisesDescription premisesDescription = new PremisesDescription
            {
                Id = model.Id,
                InnerNumber = model.InnerNumber,
                NumberByBTI = model.NumberByBTI,
                DateOfCurrentInformation = model.DateOfCurrentInformation,
            };
            _premisesDescriptionRepository.EditRecord(premisesDescription);
        }

        public IEnumerable<PremisesDescriptionMainViewModel> GetMainInformation()
        {
            return _premisesDescriptionRepository.GetMainInformation()
                .Select(information => new PremisesDescriptionMainViewModel
                {
                    InnerNumber = information.InnerNumber,
                    HousingIndex = information.HousingIndex,
                    Division = information.ResponsibilityForPremises.Division,
                    Type = information.PurposeOfPremises.Type,
                    Sort = information.PurposeOfPremises.Sort,
                    

                    Availability = information.AccessibilityForPersonsWithDisabilities.Availability,
                    UnderRepair = information.RepairStatus.UnderRepair
                });
        }

        public IEnumerable<PremisesDescriptionMainViewModel> FilteringMainInformation(
            IEnumerable<PremisesDescriptionMainViewModel> toFilter, string division)
        {
            return toFilter.Where(record => record.Division == division);
        }


        public PremisesDescriptionViewModel GetDescriptionByNumber(string number)
        {
            var premisesDescription = _premisesDescriptionRepository.GetDescriptionByNumber(number);

            return new PremisesDescriptionViewModel
            {
                InnerNumber = premisesDescription.InnerNumber,
            };

        }

        
        public PremisesDescriptionEditViewModel GetEditDescriptionByNumber(string number)
        {
            var premisesDescription = _premisesDescriptionRepository.GetDescriptionByNumber(number);

            return new PremisesDescriptionEditViewModel
            {
                Id = premisesDescription.Id,
                InnerNumber = premisesDescription.InnerNumber,
                NumberByBTI = premisesDescription.NumberByBTI,
                DateOfCurrentInformation = premisesDescription.DateOfCurrentInformation
            };

        }

    }
}
