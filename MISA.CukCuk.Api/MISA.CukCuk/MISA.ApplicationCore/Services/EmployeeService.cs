using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using MISA.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;

        #region constructor
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        #endregion


        public ServiceResult AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public ServiceResult DeleteEmployee(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();
            return employees;
        }

        public ServiceResult UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
