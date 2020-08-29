using System;
using System.Collections.Generic;

namespace ProgrammeFeature.Domain.Entities.ProgrammeFeature
{
    public partial class ProgrammeOwners
    {
        public long Id { get; set; }
        public long ProgrammeId { get; set; }
        public string ProgrammeOwner { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
