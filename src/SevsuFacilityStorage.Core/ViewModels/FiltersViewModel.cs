using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevsuFacilityStorage.Core.ViewModels
{
    public class FiltersViewModel
    {
        public string InnerNumber { set; get; }

        public string HousingIndex { get; set; }

        public string Division { get; set; }

        public string Type { get; set; }  //Тип помещения

        public string Sort { get; set; }  // Вид помещения

        public int? NumberOfSeats { get; set; }

        public string BoardType { get; set; }

        public bool? IsTSO { get; set; }  //наличие технических средств обучения (ТСО)

        public string Availability { get; set; }

        public bool? UnderRepair { get; set; }
    }
}
