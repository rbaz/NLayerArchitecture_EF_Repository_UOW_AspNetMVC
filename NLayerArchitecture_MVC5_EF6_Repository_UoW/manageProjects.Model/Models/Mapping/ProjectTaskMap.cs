using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageProjects.Model.Models.Mapping
{
    public class ProjectTaskMap : EntityTypeConfiguration<ProjectTask>
    {
        public ProjectTaskMap()
        {
            // Table 
            ToTable("ProjectTask");

            // Primary Key
            HasKey(t => t.ProjectTaskId);

            // Column Mappings

            Property(t => t.ProjectTaskId)
                .HasColumnName("ProjectTaskId");

            Property(t => t.AssignedTo)
                .HasColumnName("AssignedTo");

            HasRequired(t => t.Employees)
               .WithMany(t => t.ProjectTasks)
               .HasForeignKey(d => d.AssignedTo)
               .WillCascadeOnDelete(false);

            Property(t => t.TaskStartDate)
                .HasColumnName("TaskStartDate")
                .HasColumnType("datetime2");

            Property(t => t.TaskEndDate)
                .HasColumnName("TaskEndDate")
                .HasColumnType("datetime2");

            Property(t => t.TaskCompletion)
                .HasColumnName("TaskCompletion");

            Property(t => t.UserStorieId)
                .HasColumnName("UserStorieId");

            HasRequired(t => t.UserStories)
               .WithMany(t => t.ProjectTasks)
               .HasForeignKey(d => d.UserStorieId)
               .WillCascadeOnDelete(false);
        }
    }
}
