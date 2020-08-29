using System;
using System.Collections.Generic;

namespace ProgrammeFeature.Domain.Entities.ProgrammeFeature
{
    public partial class ProgrammeMasterUsers
    {
        public long Id { get; set; }
        public string ProgrammeMasterOwner { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
