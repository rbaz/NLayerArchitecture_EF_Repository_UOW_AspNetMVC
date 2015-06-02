using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace manageProjects.Model.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Table
            ToTable("Employee");

            // Primary Key
            HasKey(t => t.EmployeeId);

            //// Properties
            Property(t => t.EmployeName);
            //IsRequired();
            //HasMaxLength(100);

            // Column Mappings

            Property(t => t.EmployeeId)
                .HasColumnName("EmployeeId");

            Property(t => t.EmployeName)
                .HasColumnName("EmployeName");

            Property(t => t.Designation)
                .HasColumnName("Designation");

            Property(t => t.ManagedId)
                .HasColumnName("ManagedId");

            Property(t => t.ContactNum)
                .HasColumnName("ContactNum");

            Property(t => t.EmailId)
                .HasColumnName("EmailId");

        }
    }
}
