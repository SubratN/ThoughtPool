﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtPool.EMS.BLL.BusinessModel;
using ThoughtPool.EMS.Domain.Models;

namespace ThoughtPool.EMS.BLL
{
    public interface IEmployeeBLL
    {
        List<EmployeeModel> GetEmployees();
        EmployeeModel GetEmployeeById(int id, int month, int year);
        void UpdateAttendance(int id, BusinessModel.Attendance attdetails);
    }
}
