using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface ICustomerService:IBaseService<Customer>
    {
        IEnumerable<Customer> GetCustomerPaging(int limit,int offset);

        IEnumerable<Customer> GetCustomerByDepartment(Guid departmentId);

    }
}
