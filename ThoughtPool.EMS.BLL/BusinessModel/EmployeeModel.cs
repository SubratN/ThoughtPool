using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtPool.EMS.Domain.Models;

namespace ThoughtPool.EMS.BLL.BusinessModel
{
    public class EmployeeModel
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public Nullable<long> Contactno { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public virtual List<Attendance> attendances { get; set; }
    }
}
