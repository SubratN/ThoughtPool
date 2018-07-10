using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtPool.EMS.BLL.BusinessModel;
using ThoughtPool.EMS.DAL;

namespace ThoughtPool.EMS.BLL
{
    public class EmployeeBLL : IEmployeeBLL
    {
        IEmployeeDAL objDal;
        public EmployeeBLL()
        {
            objDal = new EmployeeDAL();
        }
        public List<EmployeeModel> GetEmployees()
        {
            var employees = objDal.GetEmployees();
            List<EmployeeModel> employeeModel = new List<EmployeeModel>();
            foreach (var item in employees)
            {
                employeeModel.Add(new EmployeeModel
                {
                    Empid = item.Empid,
                    Name = item.Name,
                    Designation = item.Designation,
                    Email = item.Email,
                    Contactno = item.Contactno,


                });
            }
            return employeeModel;
        }
        public EmployeeModel GetEmployee(int id)
        {
            var emp = objDal.GetEmployee(id);
            EmployeeModel employeeModel = new EmployeeModel()
            {
                Name = emp.Name,
                Designation = emp.Designation,
                Email = emp.Email,
                Contactno = emp.Contactno
            };
            return employeeModel;
        }

        public EmployeeModel GetEmployeeById(int id, int month, int year)
        {
            var employees = objDal.GetEmployee(id, month, year);
            EmployeeModel employeeModels = new EmployeeModel()
            {
                Empid = employees.Empid,
                Name = employees.Name,
                Designation = employees.Designation,
                Contactno = employees.Contactno,
                Email = employees.Email,
            };

            employeeModels.attendances = new List<BusinessModel.Attendance>();
            var dates = GetDates(year, month);

            foreach (var day in dates)
            {
                BusinessModel.Attendance objAtt = new BusinessModel.Attendance();
                objAtt.Date = day.Date;
                var attendanceDetail = employees.Attendances.Where(x => x.Day == day).FirstOrDefault();
                if (attendanceDetail != null)
                {

                    objAtt.AttendanceId = attendanceDetail.AttendanceId;
                    objAtt.InTime = attendanceDetail.InTime;
                    objAtt.OutTime = attendanceDetail.OutTime;
                    objAtt.StatusId = attendanceDetail.AttendanceStatu.StatusId;
                    objAtt.StatusCode = attendanceDetail.AttendanceStatu.StatusCode;
                }
                employeeModels.attendances.Add(objAtt);
            }

            return employeeModels;
        }

        public void UpdateAttendance(List<Attendance> attdetails)
        {
            List<Domain.Models.Attendance> att = new List<Domain.Models.Attendance>();

            foreach (var item in attdetails)
            {
                att.Add(new Domain.Models.Attendance()
                {
                    AttendanceId = item.AttendanceId,
                    InTime = item.InTime,
                    OutTime = item.OutTime,
                    Day = item.Date,
                    StatusId = item.StatusId
                });
            }
            objDal.UpdateAttendance(att);
        }

        public List<DateTime> GetDates(int year, int month)
        {
            var dates = new List<DateTime>();

            // Loop from the first day of the month until we hit the next month, moving forward a day at a time
            for (var date = new DateTime(year, month, 1);
                date.Month == month;
                date = date.AddDays(1))
            {
                dates.Add(date);
            }

            return dates;
        }
    }
}
