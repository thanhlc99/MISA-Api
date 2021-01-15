using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface ICustomerService:IBaseService<Customer>
    {
        /// <summary>
        /// lấy danh sách khách hàng theo các tiêu chí
        /// </summary>
        /// <param name="specs">theo mã, tên hoặc số điện thoại của khách hàng</param>
        /// <returns>Danh sách khách hàng theo các tiêu chí</returns>
        /// createdBy:MVThanh (15/01/2021)
        List<Customer> GetCustomersFilter(string specs);
    }
}
