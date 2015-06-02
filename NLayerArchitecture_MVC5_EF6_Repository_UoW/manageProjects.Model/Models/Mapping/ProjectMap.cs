using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace manageProjects.Model.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {

        public ProjectMap()
        {
            // Table
            ToTable("Project");

            // Primary Key
            HasKey(t => t.ProjectId);

            // Properties
            Property(t => t.ProjectName)
            .IsRequired()
            .HasMaxLength(100);

            //Column Mappings

            Property(t => t.ProjectId)
                .HasColumnName("ProjectId");

            Property(t => t.ProjectName)
                .HasColumnName("ProjectName");

            Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("datetime2");

            Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("datetime2");

            Property(t => t.CustomerName)
                .HasColumnName("CustomerName")
                .HasMaxLength(100); 
        }
    }
}
