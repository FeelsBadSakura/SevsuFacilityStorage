using Newtonsoft.Json;
using SevsuFacilityStorage.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.ViewModels
{
    public class PremisesDescriptionViewModel
    {
        public string InnerNumber { set; get; }

        public string NumberByBTI { get; set; }

        public DateTime DateOfCurrentInformation { get; set; }

        public string HousingIndex { get; set; }

        public string ExtractFromEGRN { get; set; }

        public string Index { get; set; }

        public int Floor { get; set; }

        public string AdditionalInfo { get; set; }

        public string Name { get; set; }

        public string Division { get; set; }

        public string Basis { get; set; }





        public string Type { get; set; }  //Тип помещения

        public string Sort { get; set; }  // Вид помещения

        public double Area { get; set; }

        public double Height { get; set; }

        public string WallCovering { get; set; }

        public string FloorCovering { get; set; }

        public string CeilingCovering { get; set; }

        public ICollection<WindowViewModel> WindowViewModels { get; set; }
        public ICollection<DoorViewModel> DoorViewModels { get; set; }

        public ICollection<LightningDeviceViewModel> LightningDeviceViewModels { get; set; }

        public bool IsStandartSocket { get; set; }

        public int? StandartSocketQuantity { get; set; }

        public bool IsHighSocket { get; set; }

        public int? HighSocketQuantity { get; set; }

        public bool IsDeEnergizingDevice { get; set; }
        public bool IsRJ45Socket { get; set; }

        public int? QuantityRJ45Socket { get; set; }

        public int SocketsOccupied { get; set; }

        public bool IsLVC { get; set; }

        public bool IsFHDNetwork { get; set; }

        public bool IsInternerAccess { get; set; }

        public ICollection<HeatingViewModel> HeatingViewModels { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalAdministrativePremiseDescriptionViewModel
            AdditionalAdministrativePremiseDescriptionViewModel
        { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalEducationalPremiseDescriptionViewModel
            AdditionalEducationalPremiseDescriptionViewModel
        { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ComputerClassDescriptionViewModel ComputerClassDescriptionViewModel { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public LabClassDescriptionViewModel LabClassDescriptionViewModel { get; set; }


        public ICollection<EquipmentViewModel> EquipmentViewModels { get; set; }
        public ICollection<SoftwareViewModel> SoftwareViewModels { get; set; }

        public string Availability { get; set; }

        public string AvailabilityCharacteristics { get; set; }







        public bool UnderRepair { get; set; }

        public DateTime StartRepairDate { get; set; }

        public DateTime PlannedEndRepairDate { get; set; }


    }
}
