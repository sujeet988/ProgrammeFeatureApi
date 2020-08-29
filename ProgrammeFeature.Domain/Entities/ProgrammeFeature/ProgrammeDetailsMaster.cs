using System;
using System.Collections.Generic;

namespace ProgrammeFeature.Domain.Entities.ProgrammeFeature
{
    public partial class ProgrammeDetailsMaster
    {
        public long Id { get; set; }
        public string ProgrammeName { get; set; }
        public string ProgrammeDescription { get; set; }
        public long Groupid { get; set; }
        public long? Portfolioid { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
