using MISA.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomerById(Guid customerId);

        Customer GetCustomerByCode(string customerCode);

        int AddCustomer(Customer customer);

        int UpdateCustomer(Customer customer);

        int DeleteCustomer(Guid customerId);
    }
}
