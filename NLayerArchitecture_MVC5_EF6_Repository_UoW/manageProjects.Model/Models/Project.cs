using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using manageProjects.Model;

namespace manageProjects.Model.Models
{
    public class Project : AuditableEntity<long>
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        //[DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        //[DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string CustomerName { get; set; }

        public virtual ICollection<UserStorie> UserStories { get; set; }           
    }
}