using System;
using System.Collections.Generic;

namespace ThoughtPool.EMS.Domain.Models
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<System.TimeSpan> InTime { get; set; }
        public Nullable<System.TimeSpan> OutTime { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<System.DateTime> Day { get; set; }
        public virtual AttendanceStatu AttendanceStatu { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
