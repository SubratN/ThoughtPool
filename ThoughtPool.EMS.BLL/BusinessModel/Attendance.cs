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
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string StatusCode { get; set; }
        public int StatusId { get; set; }
        public int AttendanceId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        
    }
}
