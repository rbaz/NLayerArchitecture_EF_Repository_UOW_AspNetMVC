using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using manageProjects.Model;

namespace manageProjects.Model.Models
{
    public class ProjectTask : AuditableEntity<long>
    {
        public int ProjectTaskId { get; set; }

        //Foreign key for Employee
        public int AssignedTo { get; set; }
        public virtual Employee Employees { get; set; }

        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int TaskCompletion { get; set; }

        //Foreign key for UserStorie
        public int UserStorieId { get; set; }
        public virtual UserStorie UserStories { get; set; }

    }
}