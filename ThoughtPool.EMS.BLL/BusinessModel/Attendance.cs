using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtPool.EMS.Domain.Models;

namespace ThoughtPool.EMS.BLL.BusinessModel
{
    public class Attendance
    {
        public TimeSpan? InTime { get; set; }
        public TimeSpan? OutTime { get; set; }
        public string StatusCode { get; set; }
        public int StatusId { get; set; }
        public int AttendanceId { get; set; }
        public DateTime Date { get; set; }
        
    }
}
