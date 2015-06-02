using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageProjects.Model.Models.Mapping
{
    public class UserStorieMap : EntityTypeConfiguration<UserStorie>
    {
        public UserStorieMap()
        {

            // Table 
            ToTable("UserStorie");

            // Primary Key
            HasKey(t => t.UserStorieId);

            HasRequired(t => t.Projects)
               .WithMany(t => t.UserStories)
               .HasForeignKey(d => d.ProjectId)
               .WillCascadeOnDelete(false);

            // Properties
            Property(t => t.Story)
                .IsRequired()
                .HasMaxLength(4000);

            // Table & Column Mappings

            Property(t => t.UserStorieId)
                .HasColumnName("UserStorieId");

            Property(t => t.Story)
                .HasColumnName("Story");


        }
    }
}
