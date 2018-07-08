using System;
using System.Collections.Generic;

namespace ThoughtPool.EMS.Domain.Models
{
    public partial class AttendanceStatu
    {
        public AttendanceStatu()
        {
            this.Attendances = new List<Attendance>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusCode { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
