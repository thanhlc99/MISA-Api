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
            var customerDuplicate = dbConnection.Query<Customer>("Proc_GetCustomerByCode",commandType:CommandType.StoredProcedure).FirstOrDefault();
            return customerDuplicate;
        }

        public IEnumerable<Customer> GetCustomerByPage(Pager pager)
        {
                var results = dbConnection.Query<Customer>($"SELECT * FROM Customer c LIMIT {pager.Offset},{pager.PageSize}", commandType:CommandType.Text);
                return results;
        }

        public int GetCustomerCount()
        {
            var counts = dbConnection.ExecuteScalar<int>("SELECT COUNT(*) AS 'Count' FROM Customer c;", commandType: CommandType.Text);
            return counts;
        }

        public List<Customer> GetCustomersFilter(string specs)
        {
            //build tham số đầu vào cho store
            var input = specs != null ? specs : string.Empty;
            var parameters = new DynamicParameters();
            parameters.Add("@CustomerCode", input,DbType.String);
            parameters.Add("@FullName", input,DbType.String);
            parameters.Add("@PhoneNumber", input,DbType.String);
            var customers = dbConnection.Query<Customer>("Proc_GetCustomerPaging", parameters, commandType: CommandType.StoredProcedure).ToList();
            return customers;
        }
    }
}
