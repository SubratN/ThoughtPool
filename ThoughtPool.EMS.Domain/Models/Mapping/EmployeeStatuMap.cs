using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ThoughtPool.EMS.Domain.Models.Mapping
{
    public class EmployeeStatuMap : EntityTypeConfiguration<EmployeeStatu>
    {
        public EmployeeStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusId);

            // Properties
            this.Property(t => t.StatusName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EmployeeStatus");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.StatusName).HasColumnName("StatusName");
        }
    }
}
