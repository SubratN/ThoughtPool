using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ThoughtPool.EMS.Domain.Models.Mapping
{
    public class DateMap : EntityTypeConfiguration<Date>
    {
        public DateMap()
        {
            // Primary Key
            this.HasKey(t => t.Day);

            // Properties
            // Table & Column Mappings
            this.ToTable("Date");
            this.Property(t => t.Day).HasColumnName("Day");
        }
    }
}
