using ASPNetCoreWebAPIDemo.Models;
using ASPNetCoreWebAPIDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWebAPIDemo.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployeesList();
        Employee GetEmployeeDetailsById(int empId);
        ResponseModel SaveEmployee(Employee employeeModel);
        ResponseModel DeleteEmployee(int employeeId);
    }
}
