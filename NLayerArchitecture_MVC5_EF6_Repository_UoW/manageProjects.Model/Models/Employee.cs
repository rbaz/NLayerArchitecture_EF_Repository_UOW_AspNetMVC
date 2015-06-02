using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using manageProjects.Model;

namespace manageProjects.Model.Models
{
    public class Employee : AuditableEntity<long>
    {
        public int EmployeeId { get; set; }
        public string EmployeName { get; set; }
        public string Designation { get; set; }
        public int ManagedId { get; set; }
        public string ContactNum { get; set; }
        public string EmailId { get; set; }

        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }

    }
}