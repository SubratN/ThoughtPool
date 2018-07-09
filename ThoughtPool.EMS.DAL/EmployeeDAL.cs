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
            empDetails.Attendances = empDetails.Attendances.Where(y => y.InTime.Value.Month == month && y.InTime.Value.Year == year
                                                                     && y.OutTime.Value.Month == month && y.OutTime.Value.Year == year).ToList();


            return empDetails;
        }
        public void UpdateAttendance(int id, Attendance att)
        {
            using (var context = new ManageAttendanceContext())
            {
                // var db = context.Attendances.FirstOrDefault(x => x.Empid == id);
                // if (db != null)
                {

                    // db.Intime = att.Intime;
                    //db.Outtime = att.Outtime;
                    //db.C_Date = att.C_Date;
                    //db.C_Status = att.C_Status;
                    context.SaveChanges();

                }
            }
        }
    }
}

