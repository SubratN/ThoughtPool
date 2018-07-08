using System;
using System.Collections.Generic;

namespace ThoughtPool.EMS.Domain.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.Attendances = new List<Attendance>();
        }

        public int Empid { get; set; }
        public string Firstname { get; set; }
        public string Designation { get; set; }
        public Nullable<long> Contactno { get; set; }
        public string Email { get; set; }
        public Nullable<int> StatusId { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual EmployeeStatu EmployeeStatu { get; set; }
    }
}
