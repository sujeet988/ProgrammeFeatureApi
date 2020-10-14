using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammeFeature.Domain.Entities.ProgrammeFeature
{
    public partial class GroupMaster
    {

        public GroupMaster()
        {
            ProjectMaster = new HashSet<ProjectMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProjectMaster> ProjectMaster
        {
            get; set;
        }
    }

}
