using System;
using System.Collections.Generic;

namespace ThoughtPool.EMS.Domain.Models
{
    public partial class EmployeeStatu
    {
        public EmployeeStatu()
        {
            this.Employees = new List<Employee>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
