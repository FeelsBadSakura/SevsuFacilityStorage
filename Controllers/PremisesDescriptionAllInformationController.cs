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
    public class PremisesDescriptionAllInformationController : ControllerBase
    {
            private readonly MainService _mainService;

            public PremisesDescriptionAllInformationController(MainService mainService)
            {
                _mainService = mainService;
            }

            [EnableCors("AllowLocalhost44321")]
            [HttpPost]
            public ActionResult<PremisesDescriptionViewModel> CreatePremiaseDescription(PremisesDescriptionViewModel model)
            {
                _mainService.CreateDescription(model);
                return Ok();
            }

            [HttpGet]
            public PremisesDescriptionViewModel GetPremise(string number)
            {
                return _mainService.GetDescriptionByNumber(number);
            }


            [HttpGet]
            public ActionResult<PremisesDescriptionEditViewModel> EditPremise(string number)
            {
                return _mainService.GetEditDescriptionByNumber(number);
            }


            [HttpPost]
            public ActionResult<PremisesDescriptionEditViewModel> EditPremise(PremisesDescriptionEditViewModel model)
            {
                _mainService.EditDescription(model);
                return Ok();
            }


            [HttpPost]
            public ActionResult<PremisesDescriptionViewModel> DeletePremise(string number)
            {
                _mainService.DeleteDescription(number);
                return Ok();
            }
        }
}
