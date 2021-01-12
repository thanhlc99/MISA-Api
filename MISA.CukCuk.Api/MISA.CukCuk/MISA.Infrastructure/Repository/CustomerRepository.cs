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
    public class CustomerRepository : ICustomerRepository
    {
        #region declare
        IConfiguration _configuration;
        string _connectionString = string.Empty;
        IDbConnection dbConnection = null;
        #endregion

        #region constructor
        public CustomerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MISACukCukConnectionString");
            dbConnection = new MySqlConnection(_connectionString);
        }
        #endregion

        #region Method
        public Customer GetCustomerByCode(string customerCode)
        {
            //khới tạo command text
            var res = dbConnection.Query<Customer>("Proc_GetCustomerByCode", new { CustomerCode = customerCode }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return res;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            //khởi tạo commandText
            var customers = dbConnection.Query<Customer>("Proc_GetCustomers", null, commandType: CommandType.StoredProcedure);
            //trả về dữ liệu
            return customers;
        }

        public Customer GetCustomerById(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public int AddCustomer(Customer customer)
        {
            var parameters = MappingDbType(customer);
            //thi thi câu lệnh
            var row = dbConnection.Execute("Proc_InsertCustomer", parameters, commandType: CommandType.StoredProcedure);
            //trả về kết quả (số bản ghi thêm mới được)
            return row;
        }



        public int UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int DeleteCustomer(Guid customerId)
        {
            throw new NotImplementedException();
        }

        private DynamicParameters MappingDbType<TEntity>(TEntity entity)
        {
            //Chuyển Guid sang string (Xử lý các kiểu dữ liệu)
            var properties = entity.GetType().GetProperties();
            var parameters = new DynamicParameters();
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);
                var propertyType = property.PropertyType;

                if (propertyType == typeof(Guid) || propertyType == typeof(Guid?))
                {
                    parameters.Add($"@{propertyName}", propertyValue, DbType.String);
                }
                else
                {
                    parameters.Add($"@{propertyName}", propertyValue);
                }
            }
            return parameters;
        }

        #endregion
    }
}
