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
            
            if (model.AdditionalAdministrativePremiseDescriptionViewModel != null)
            {
                premisesDescription.AdditionalAdministrativePremiseDescription =
                    new AdditionalAdministrativePremiseDescription
                    {
                        FilledfJobsQuantity = model.AdditionalAdministrativePremiseDescriptionViewModel.FilledfJobsQuantity,
                        AllowedJobsQuantity = model.AdditionalAdministrativePremiseDescriptionViewModel.AllowedJobsQuantity
                    };
            }

            if (model.AdditionalEducationalPremiseDescriptionViewModel != null)
            {

                premisesDescription.AdditionalEducationalPremiseDescription =
                    new AdditionalEducationalPremiseDescription
                    {
                        AvailableSeatsQuantity = model.AdditionalEducationalPremiseDescriptionViewModel.AvailableSeatsQuantity,
                        BoardType = model.AdditionalEducationalPremiseDescriptionViewModel.BoardType,
                        HasBoard = model.AdditionalEducationalPremiseDescriptionViewModel.HasBoard,
                        HasStorage = model.AdditionalEducationalPremiseDescriptionViewModel.HasStorage,
                        HasTeachingAids = model.AdditionalEducationalPremiseDescriptionViewModel.HasTeachingAids,
                        TeacherJobsQuantity = model.AdditionalEducationalPremiseDescriptionViewModel.TeacherJobsQuantity
                    };
            }

            if (model.ComputerClassDescriptionViewModel != null)
            {
                premisesDescription.ComputerClassDescription = new ComputerClassDescription
                {
                    PersonalComputersQuantity = model.ComputerClassDescriptionViewModel.PersonalComputersQuantity,
                    Type = model.ComputerClassDescriptionViewModel.Type
                };
            }

            if (model.LabClassDescriptionViewModel!= null)
            {
                premisesDescription.LabClassDescription = new LabClassDescription
                {
                    Purpose = model.LabClassDescriptionViewModel.Purpose,
                    Type = model.ComputerClassDescriptionViewModel.Type
                };
            }

            _premisesDescriptionRepository.CreateRecord(premisesDescription);
        }

        public void DeleteDescription(string number)
        {
            _premisesDescriptionRepository.DeleteRecord(number);
        }

        public IEnumerable<PremisesDescriptionMainViewModel> GetMainInformation(FiltersViewModel filtersViewModel,
            int page, int pageSize)
        {

            var mainInformation = _premisesDescriptionRepository.GetMainInformation(filtersViewModel,page,pageSize);
            List<PremisesDescriptionMainViewModel> model = new List<PremisesDescriptionMainViewModel>();
            foreach (var item in mainInformation)
            {
                var premiseDescriptionViewModel = new PremisesDescriptionMainViewModel
                {

                    InnerNumber = item.InnerNumber,
                    HousingIndex = item.HousingIndex,
                    Division = item.ResponsibilityForPremises.Division,
                    Type = item.PurposeOfPremises.Type,
                    Sort = item.PurposeOfPremises.Sort, 
                    Availability = item.AccessibilityForPersonsWithDisabilities.Availability,
                    UnderRepair = item.RepairStatus.UnderRepair
                };
                if (item.AdditionalEducationalPremiseDescription != null)
                {
                    premiseDescriptionViewModel.NumberOfSeats = item.AdditionalEducationalPremiseDescription.AvailableSeatsQuantity;
                    premiseDescriptionViewModel.BoardType = item.AdditionalEducationalPremiseDescription.BoardType;
                    premiseDescriptionViewModel.IsTSO = item.AdditionalEducationalPremiseDescription.HasTeachingAids;
                };
                if (item.AdditionalAdministrativePremiseDescription != null)
                {
                    premiseDescriptionViewModel.NumberOfSeats = item.AdditionalAdministrativePremiseDescription.AllowedJobsQuantity;
                };
                model.Add(premiseDescriptionViewModel);
            };    
            return model;
        }


        public PremisesDescriptionViewModel GetDescriptionByNumber(string number, DateTime dateOfCurrentInformation)
        {
            var premiseDescription = _premisesDescriptionRepository.GetDescriptionByNumber(number, dateOfCurrentInformation);

            ICollection<WindowViewModel> windows = new List<WindowViewModel>();
            foreach (var window in premiseDescription.GeneralInformation.Windows)
            {
                windows.Add(new WindowViewModel
                {
                    Type = window.Type,
                    Quantity = window.Quantity,
                    Direction = window.Direction,
                    Obstacles = window.Obstacles,
                    Area = window.Area,
                    Grids = window.Grids
                });
            }

            ICollection<DoorViewModel> doors = new List<DoorViewModel>();
            foreach (var door in premiseDescription.GeneralInformation.Doors)
            {
                doors.Add(new DoorViewModel
                {
                    Type = door.Type,
                    Quantity = door.Quantity,
                    IsElectronicLock = door.IsElectronicLock
                });
            }

            ICollection<LightningDeviceViewModel> lightingDevices = new List<LightningDeviceViewModel>();
            foreach (var lightingDevice in premiseDescription.GeneralInformation.LightingDevices)
            {
                lightingDevices.Add(new LightningDeviceViewModel
                {
                    Type = lightingDevice.Type,
                    Quantity = lightingDevice.Quantity
                });
            }

            ICollection<HeatingViewModel> heatings = new List<HeatingViewModel>();
            foreach (var heating in premiseDescription.GeneralInformation.Heatings)
            {
                heatings.Add(new HeatingViewModel
                {
                    Type = heating.Type,
                    Quantity = heating.Quantity
                });
            }

            ICollection<EquipmentViewModel> equipments = new List<EquipmentViewModel>();
            foreach (var equipment in premiseDescription.Equipments)
            {
                equipments.Add(new EquipmentViewModel
                {
                    Type = equipment.Type,
                    Quantity = equipment.Quantity,
                    Name = equipment.Name,
                    Description = equipment.Description,
                    InventoryNumber = equipment.InventoryNumber
                });
            }

            ICollection<SoftwareViewModel> softwares = new List<SoftwareViewModel>();
            foreach (var software in premiseDescription.Softwares)
            {
                softwares.Add(new SoftwareViewModel
                {
                    Name = software.Name,
                    Description = software.Description,
                    LicenseType = software.LicenseType
                });
            }


            var premiseDescriptionViewModel = new PremisesDescriptionViewModel
            {
                InnerNumber = premiseDescription.InnerNumber,
                NumberByBTI = premiseDescription.NumberByBTI,
                DateOfCurrentInformation = premiseDescription.DateOfCurrentInformation,
                HousingIndex = premiseDescription.HousingIndex,
                ExtractFromEGRN = premiseDescription.ExtractFromEGRN,
                Index = premiseDescription.Index,
                Floor = premiseDescription.Floor,
                AdditionalInfo = premiseDescription.AdditionalInfo,
                Name = premiseDescription.Name,
                Division = premiseDescription.ResponsibilityForPremises.Division,
                Basis = premiseDescription.ResponsibilityForPremises.Basis,
                Type = premiseDescription.PurposeOfPremises.Type,
                Sort = premiseDescription.PurposeOfPremises.Sort,
                Area = premiseDescription.GeneralInformation.Area,
                Height = premiseDescription.GeneralInformation.Height,
                WallCovering = premiseDescription.GeneralInformation.WallCovering,
                FloorCovering = premiseDescription.GeneralInformation.FloorCovering,
                CeilingCovering = premiseDescription.GeneralInformation.CeilingCovering,
                WindowViewModels = windows,
                DoorViewModels = doors,
                LightningDeviceViewModels = lightingDevices,
                IsStandartSocket = premiseDescription.GeneralInformation.ElectricitySupply.IsStandartSocket,
                StandartSocketQuantity = premiseDescription.GeneralInformation.ElectricitySupply.StandartSocketQuantity,
                IsHighSocket = premiseDescription.GeneralInformation.ElectricitySupply.IsHighSocket,
                IsDeEnergizingDevice = premiseDescription.GeneralInformation.ElectricitySupply.IsDeEnergizingDevice,
                IsRJ45Socket = premiseDescription.GeneralInformation.NetworkCharacteristics.IsRJ45Socket,
                QuantityRJ45Socket = premiseDescription.GeneralInformation.NetworkCharacteristics.Quantity,
                SocketsOccupied = premiseDescription.GeneralInformation.NetworkCharacteristics.SocketsOccupied,
                IsLVC = premiseDescription.GeneralInformation.NetworkCharacteristics.IsLVC,
                IsFHDNetwork = premiseDescription.GeneralInformation.NetworkCharacteristics.IsFHDNetwork,
                IsInternerAccess = premiseDescription.GeneralInformation.NetworkCharacteristics.IsInternerAccess,
                HeatingViewModels = heatings,
                EquipmentViewModels = equipments,
                SoftwareViewModels = softwares,

                Availability = premiseDescription.AccessibilityForPersonsWithDisabilities.Availability,
                AvailabilityCharacteristics = premiseDescription.AccessibilityForPersonsWithDisabilities.AvailabilityCharacteristics,
                UnderRepair = premiseDescription.RepairStatus.UnderRepair,
                StartRepairDate = premiseDescription.RepairStatus.StartDate,
                PlannedEndRepairDate = premiseDescription.RepairStatus.PlannedEndDate,

            };


            if (premiseDescription.AdditionalEducationalPremiseDescription != null)
            {
                premiseDescriptionViewModel.AdditionalEducationalPremiseDescriptionViewModel =
                    new AdditionalEducationalPremiseDescriptionViewModel
                    {
                        AvailableSeatsQuantity = premiseDescription.AdditionalEducationalPremiseDescription.AvailableSeatsQuantity,
                        BoardType = premiseDescription.AdditionalEducationalPremiseDescription.BoardType,
                        HasBoard = premiseDescription.AdditionalEducationalPremiseDescription.HasBoard,
                        HasStorage = premiseDescription.AdditionalEducationalPremiseDescription.HasStorage,
                        HasTeachingAids = premiseDescription.AdditionalEducationalPremiseDescription.HasTeachingAids,
                        TeacherJobsQuantity = premiseDescription.AdditionalEducationalPremiseDescription.TeacherJobsQuantity
                    };
            };
            if (premiseDescription.AdditionalAdministrativePremiseDescription != null)
            {
                premiseDescriptionViewModel.AdditionalAdministrativePremiseDescriptionViewModel =
                    new AdditionalAdministrativePremiseDescriptionViewModel
                    {
                        FilledfJobsQuantity = premiseDescription.AdditionalAdministrativePremiseDescription.FilledfJobsQuantity,
                        AllowedJobsQuantity = premiseDescription.AdditionalAdministrativePremiseDescription.AllowedJobsQuantity
                    };
            };
            if (premiseDescription.ComputerClassDescription != null)
            {
                premiseDescriptionViewModel.ComputerClassDescriptionViewModel =
                    new ComputerClassDescriptionViewModel
                    {
                        PersonalComputersQuantity = premiseDescription.ComputerClassDescription.PersonalComputersQuantity,
                        Type = premiseDescription.ComputerClassDescription.Type
                    };
            }
            if (premiseDescription.LabClassDescription != null)
            {
                premiseDescriptionViewModel.LabClassDescriptionViewModel =
                    new LabClassDescriptionViewModel
                    {
                        Purpose = premiseDescription.LabClassDescription.Purpose,
                        Type = premiseDescription.LabClassDescription.Type
                    };
            }

                return premiseDescriptionViewModel;
        }

    }
}
