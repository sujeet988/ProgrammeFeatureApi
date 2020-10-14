using System;
using System.Collections.Generic;
using System.Text;
using ProgrammeFeature.Domain.Entities;
using ProgrammeFeature.Domain.Entities.ProgrammeFeature;

namespace ProgrammeFeature.Business.InterFaces
{
  public   interface IProgrammeDetailsMaster
    {

        int Save(ProgrammeDetailsMaster programmeDetailsMaster);

        List<ProgrammeDetailsMaster> GetProgrammeDetailsMaster();
        List<GroupMaster> GetGroups();
        List<ProjectMaster> GetAllProjectByGroupid(int groupid);


    }



}
