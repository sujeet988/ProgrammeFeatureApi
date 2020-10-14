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


        [HttpGet("GroupDetails")]
        public IActionResult GroupDetails()
        {
            List<GroupMaster> groupMasters = _programmeDetailsMaster.GetGroups();
            return Ok(groupMasters);

        }

        [HttpGet("ProjectDetailsByGroup/{groupid}")]
        public IActionResult ProjectDetailsByGroup(int groupid)
        {
            List<ProjectMaster> projectMasters = _programmeDetailsMaster.GetAllProjectByGroupid(groupid);
            return Ok( projectMasters);

        }


        [HttpGet]
        public IActionResult GetProgrammeDetailsMasterData()
        {
            List<ProgrammeDetailsMaster> programmeDetailsMasters = _programmeDetailsMaster.GetProgrammeDetailsMaster();
            return Ok(programmeDetailsMasters);
        }

        [HttpPost]
        public IActionResult PostProgrammeDetailsMasterData([FromBody] ProgrammeDetailsMaster programmeDetailsMaster)
        {
            var i = _programmeDetailsMaster.Save(programmeDetailsMaster);
            return Ok(i);
        }




    }
}



