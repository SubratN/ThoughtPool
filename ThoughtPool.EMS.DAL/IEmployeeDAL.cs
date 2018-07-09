using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtPool.EMS.Domain.Models;

namespace ThoughtPool.EMS.DAL
{
    public interface IEmployeeDAL
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        Employee GetEmployee(int id, int month, int year);
        void UpdateAttendance(int id, Attendance att);
    }
}
