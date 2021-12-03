using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SevsuFacilityStorage.ViewModels
{
    public class FilterViewModel
    {
        public FilterViewModel(List<DateTime> dates, DateTime? data)
        {
            Dates = new SelectList(dates, data);
            SelectedData = data;
        }
        public SelectList Dates { get; private set; }
        public DateTime? SelectedData { get; private set; } 
    }
}
