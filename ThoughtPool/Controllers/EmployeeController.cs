using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThoughtPool.EMS.BLL;
using ThoughtPool.EMS.BLL.BusinessModel;

namespace ThoughtPool.Controllers
{
    public class EmployeeController : ApiController
    {
        IEmployeeBLL objBLL;
        public EmployeeController()
        {
            objBLL = new EmployeeBLL();
        }
        [Route("api/Employees/All")]
        public List<EmployeeModel> GetEmployees()
        {
            return objBLL.GetEmployees();
        }
        [Route("api/Employee/Emp")]
        public EmployeeModel GetEmployee(int id)
        {
           return objBLL.GetEmployee(id);
        }
        [Route("api/Employee/Att")]
        public EmployeeModel GetEmp(int id, int month, int year)
        {
            return objBLL.GetEmployeeById(id,month,year);
        }
        public void UpdateAttendance(int id, [FromBody]Attendance attdetails)
        {
            objBLL.UpdateAttendance(id, attdetails);
        }
    }
}
