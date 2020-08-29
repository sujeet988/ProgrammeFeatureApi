using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgrammeFeature.Business.InterFaces;
using ProgrammeFeature.Domain.Entities.ProgrammeFeature;

namespace ProgrammeFeature.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammeDetailsMasterController : BaseController<ProgrammeDetailsMasterController>
    {

        private IProgrammeDetailsMaster _programmeDetailsMaster;

        public ProgrammeDetailsMasterController(IProgrammeDetailsMaster programmeDetailsMaster)
        {
            _programmeDetailsMaster = programmeDetailsMaster;

        }

        [HttpGet]
        public IActionResult GetProgrammeDetailsMasterData()
        {
            List<ProgrammeDetailsMaster> programmeDetailsMasters = _programmeDetailsMaster.Get();
            return Ok(programmeDetailsMasters);
        }

        [HttpPost]
        public IActionResult PostProgrammeDetailsMasterData(ProgrammeDetailsMaster programmeDetailsMaster)
        {
            var i = _programmeDetailsMaster.Save(programmeDetailsMaster);
            return Ok(i);
        }



    }
}



