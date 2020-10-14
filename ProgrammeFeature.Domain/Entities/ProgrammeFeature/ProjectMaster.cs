using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammeFeature.Domain.Entities.ProgrammeFeature
{
  public partial  class ProjectMaster
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Groupid { get; set; }

        public virtual GroupMaster Group { get; set; }
    }
}
