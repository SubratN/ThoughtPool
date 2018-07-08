using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ThoughtPool.EMS.Domain.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Empid);

            // Properties
            this.Property(t => t.Empid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Firstname)
                .HasMaxLength(50);

            this.Property(t => t.Designation)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Employee");
            this.Property(t => t.Empid).HasColumnName("Empid");
            this.Property(t => t.Firstname).HasColumnName("Firstname");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.Contactno).HasColumnName("Contactno");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.StatusId).HasColumnName("StatusId");

            // Relationships
            this.HasOptional(t => t.EmployeeStatu)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.StatusId);

        }
    }
}
