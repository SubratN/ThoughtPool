using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ThoughtPool.EMS.Domain.Models.Mapping
{
    public class AttendanceStatuMap : EntityTypeConfiguration<AttendanceStatu>
    {
        public AttendanceStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusId);

            // Properties
            this.Property(t => t.StatusName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StatusCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("AttendanceStatus");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.StatusName).HasColumnName("StatusName");
            this.Property(t => t.StatusCode).HasColumnName("StatusCode");
        }
    }
}
