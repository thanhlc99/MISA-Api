using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Interfaces;
using MISA.ApplicationCore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region declare
        IConfiguration _configuration;
        string _connectionString = string.Empty;
        IDbConnection dbConnection = null;
        #endregion

        #region constructor
        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MISACukCukConnectionString");
            dbConnection = new MySqlConnection(_connectionString);
        }
        #endregion
        public int AddEmployee(Employee employee)
        {
            throw new NotImplementedException();

        }

        public int DeleteEmployee(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByCode(string employeeCode)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(Guid employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            //khởi tạo commandText
            var employees = dbConnection.Query<Employee>(" Proc_GetEmployees", null, commandType: CommandType.StoredProcedure);
            //trả về dữ liệu
            return employees;
        }

        public int UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
