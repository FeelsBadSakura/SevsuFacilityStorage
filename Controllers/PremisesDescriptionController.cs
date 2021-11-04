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
    public class PremisesDescriptionController : ControllerBase
    {
        private readonly IPremisesDescriptionRepository _premisesDescriptionRepository;

        private readonly MainService _mainService;

        public PremisesDescriptionController(IPremisesDescriptionRepository premisesDescriptionRepository,
            MainService mainService)
        {
            _premisesDescriptionRepository = premisesDescriptionRepository;
            _mainService = mainService;
        }

        [HttpPost]
        public ActionResult<PremisesDescriptionViewModel> PostPremiasesDescription(PremisesDescriptionViewModel model)
        {
            _mainService.CreateDescription(model);
            return Ok();
        }

        [HttpGet]
        public PremisesDescriptionViewModel GetPremiases(string number)
        {
            return _mainService.GetDescriptionByNumber(number);
        }

        [HttpGet]
        public IEnumerable<PremisesDescriptionMainViewModel> GetMainInformation()
        {
            return _mainService.GetMainInformation();
        }
    }
}
