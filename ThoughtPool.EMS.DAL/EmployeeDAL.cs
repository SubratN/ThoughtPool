using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;

using ThoughtPool.EMS.Domain.Models;

namespace ThoughtPool.EMS.DAL
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> GetEmployees()
        {
            ManageAttendanceContext context = new ManageAttendanceContext();
            return context.Employees.Where(x => x.StatusId == 1).ToList();

        }
        public Employee GetEmployee(int id)
        {
            ManageAttendanceContext context = new ManageAttendanceContext();
            return context.Employees.Where(x => x.Empid == id).FirstOrDefault();
        }
        public Employee GetEmployee(int id, int month, int year)
        {
            ManageAttendanceContext context = new ManageAttendanceContext();
            var empDetails = context.Employees.Where(x => x.Empid == id).FirstOrDefault();
            empDetails.Attendances = empDetails.Attendances.Where(y => y.Day.Value.Month == month && y.Day.Value.Year == year).ToList();

            return empDetails;
        }
        public void UpdateAttendance(List<Attendance> att)
        {
            ManageAttendanceContext context = new ManageAttendanceContext();
            foreach (var item in att)
            {
              var attObject=  context.Attendances.Where(x => x.AttendanceId == item.AttendanceId).FirstOrDefault();
                if (attObject!=null)
                {
                    attObject.StatusId = item.StatusId;
                    attObject.InTime = item.InTime;
                    attObject.OutTime = item.OutTime;
                    context.Attendances.Attach(attObject);
                    context.Entry(attObject).State = EntityState.Modified;
                }
                else
                {
                    context.Attendances.Add(item);
                }
            }
            

            context.SaveChanges();

        }
    }
}

