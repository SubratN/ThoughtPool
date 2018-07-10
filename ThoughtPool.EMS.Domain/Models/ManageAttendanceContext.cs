using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ThoughtPool.EMS.Domain.Models.Mapping;

namespace ThoughtPool.EMS.Domain.Models
{
    public partial class ManageAttendanceContext : DbContext
    {
        static ManageAttendanceContext()
        {
            Database.SetInitializer<ManageAttendanceContext>(null);
        }

        public ManageAttendanceContext()
            : base("Name=ManageAttendanceContext")
        {
        }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<AttendanceStatu> AttendanceStatus { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeStatu> EmployeeStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttendanceMap());
            modelBuilder.Configurations.Add(new AttendanceStatuMap());
            modelBuilder.Configurations.Add(new DateMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeStatuMap());
        }
    }
}
