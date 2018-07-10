using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ThoughtPool.EMS.Domain.Models.Mapping
{
    public class AttendanceMap : EntityTypeConfiguration<Attendance>
    {
        public AttendanceMap()
        {
            // Primary Key
            this.HasKey(t => t.AttendanceId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Attendance");
            this.Property(t => t.AttendanceId).HasColumnName("AttendanceId");
            this.Property(t => t.EmpId).HasColumnName("EmpId");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.Day).HasColumnName("Day");

            // Relationships
            this.HasOptional(t => t.AttendanceStatu)
                .WithMany(t => t.Attendances)
                .HasForeignKey(d => d.StatusId);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.Attendances)
                .HasForeignKey(d => d.EmpId);

        }
    }
}
