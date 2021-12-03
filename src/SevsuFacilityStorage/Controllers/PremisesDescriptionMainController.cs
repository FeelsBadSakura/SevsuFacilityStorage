using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SevsuFacilityStorage.Abstractions;
using SevsuFacilityStorage.Models;
using SevsuFacilityStorage.Service;
using SevsuFacilityStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace SevsuFacilityStorage.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PremisesDescriptionMainController : ControllerBase
    {
        private readonly MainService _mainService;

        public PremisesDescriptionMainController(MainService mainService)
        {
            _mainService = mainService;
        }

        [HttpGet]
        public ActionResult<IndexViewModel> GetMainInformation(DateTime? data, int page = 1)
        {
            int pageSize = 3;

            var list = _mainService.GetMainInformation();
            if (data != null)
            {
                list = _mainService.FilteringMainInformation(list, (DateTime)data);
            }
            var count = list.Count();
            list = list.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                FilterViewModel = new FilterViewModel(new List<DateTime> { DateTime.UtcNow, list.FirstOrDefault().DateOfCurrentInformation },data),
                PremisesDescriptions = list
            };
            
            return viewModel;
        }

    } 
}
