using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SevsuFacilityStorage.Abstractions;
using SevsuFacilityStorage.Models;
using SevsuFacilityStorage.Core.Service;
using SevsuFacilityStorage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SevsuFacilityStorage.Core.ViewModels;

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

        [HttpPost]
        public IEnumerable<PremisesDescriptionMainViewModel> GetMainInformation(FiltersViewModel filtersViewModel, int page = 1,int pageSize = 10)
        {
            var list = _mainService.GetMainInformation(filtersViewModel,page,pageSize);           
            return list;
        }

    } 
}
