using Microsoft.AspNetCore.Mvc;
using SevsuFacilityStorage.Abstractions;
using SevsuFacilityStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace SevsuFacilityStorage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremiasesDescriptionController : ControllerBase
    {
        private readonly IPremiasesDescriptionRepository _premiasesDescriptionRepository;

        public PremiasesDescriptionController(IPremiasesDescriptionRepository premiasesDescriptionRepository)
        {
            _premiasesDescriptionRepository = premiasesDescriptionRepository;
        }

        [HttpPost]
        public ActionResult<PremiasesDescription> PostPremiasesDescription(PremiasesDescription premiasesDescription)
        {
            _premiasesDescriptionRepository.CreateRecord(premiasesDescription);
            return Ok();
        }

        [HttpGet]
        public IEnumerable<PremiasesDescription> GetPremiases()
        {
            return _premiasesDescriptionRepository.GetAllDescriptions();
        }
    }
}
