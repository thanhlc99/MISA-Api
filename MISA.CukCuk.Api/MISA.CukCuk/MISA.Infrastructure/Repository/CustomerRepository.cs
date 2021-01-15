using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Interfaces;
using MISA.ApplicationCore.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MISA.Infrastructure.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration) :base(configuration)
        {

        }

        public Customer GetCustomerByCode(string customerCode)
        {
            var customerDuplicate = dbConnection.Query<Customer>($"Proc_Get{tableName}ByCode",commandType:CommandType.StoredProcedure).FirstOrDefault();
            return customerDuplicate;
        }

        public List<Customer> GetCustomersFilter(string specs)
        {
            //build tham số đầu vào cho store
            var parameters = new DynamicParameters();
            parameters.Add("@CustomerCode", specs);
            parameters.Add("@FullName", specs);
            parameters.Add("@PhoneNumber", specs);
            var customers = dbConnection.Query<Customer>("Proc_GetCustomerPaging", parameters, commandType: CommandType.StoredProcedure).ToList();
            return customers;
        }
    }
}
