using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammeFeature.Business.InterFaces;
using ProgrammeFeature.Domain.Entities.ProgrammeFeature;

namespace ProgrammeFeature.Business.Services
{

    public class ProgrammeDetailsMasterService : IProgrammeDetailsMaster
    {
        private readonly ProgrammefeatureContext _programmefeatureContext;

        public ProgrammeDetailsMasterService(ProgrammefeatureContext programmefeatureContext)
        {
            _programmefeatureContext = programmefeatureContext;
        }

        public List<ProgrammeDetailsMaster> Get()
        {

            return _programmefeatureContext.ProgrammeDetailsMaster.ToList();

        }

        public int Save(ProgrammeDetailsMaster programmeDetailsMaster)
        {
            using (_programmefeatureContext)
            {
                try
                {
                    _programmefeatureContext.ProgrammeDetailsMaster.Add(programmeDetailsMaster);
                    int output = _programmefeatureContext.SaveChanges();
                    return output;

                }

                catch (Exception ex)
                {
                    throw ex;
                }


            }



        }
    }



}
