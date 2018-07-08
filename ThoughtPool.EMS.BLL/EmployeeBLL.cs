using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtPool.EMS.BLL.BusinessModel;
using ThoughtPool.EMS.DAL;
using ThoughtPool.EMS.Domain;

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
                    Firstname = item.Firstname,
                    Designation = item.Designation,
                    Email = item.Email,
                    Contactno = item.Contactno,


                });
            }
            return employeeModel;
        }

        public EmployeeModel GetEmployeeById(int id, int month, int year)
        {
            var employees = objDal.GetEmployee(id, month, year);
            EmployeeModel employeeModels = new EmployeeModel()
            {
                Empid = employees.Empid,
                Firstname = employees.Firstname,
                Designation = employees.Designation,
                Contactno = employees.Contactno,
                Email = employees.Email,
            };

            employeeModels.attendances = new List<Attendance>();
            foreach (var att in employees.Attendances)
            {
                employeeModels.attendances.Add(new Attendance
                {
                    AttendanceId = att.AttendanceId,
                    InTime = Convert.ToDateTime(att.InTime).ToShortTimeString(),
                    OutTime = Convert.ToDateTime(att.OutTime).ToShortTimeString(),
                    Date = Convert.ToDateTime(Convert.ToDateTime(att.InTime).ToShortDateString()),
                    StatusId= att.AttendanceStatu.StatusId,
                    StatusCode=att.AttendanceStatu.StatusCode
                });
            }
            return employeeModels;
        }
        public void UpdateAttendance(int id, Attendance attdetails)
        {
           // if (attdetails.C_Status == "P" || attdetails.C_Status == "A" || attdetails.C_Status == "L" || attdetails.C_Status == "LP")
            {
                Domain.Models.Attendance obj = new Domain.Models.Attendance()
                {

                    //Intime = attdetails.Intime,
                    //Outtime = attdetails.Outtime,
                    //C_Date = attdetails.C_Date,
                    // C_Status = attdetails.C_Status
                };
                objDal.UpdateAttendance(id, obj);
            }

        }
    }
}
