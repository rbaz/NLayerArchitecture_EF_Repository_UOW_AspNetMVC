using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using manageProjects.Model;

namespace manageProjects.Model.Models
{
    public class UserStorie : AuditableEntity<long>
    {

        public int UserStorieId { get; set; }
        public string Story { get; set; }

        //Foreign key for Project
        public int ProjectId { get; set; }
        public virtual Project Projects { get; set; }

        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}