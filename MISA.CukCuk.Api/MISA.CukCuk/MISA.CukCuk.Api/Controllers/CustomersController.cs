using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Interfaces;
using MISA.ApplicationCore.Models;
using MISA.ApplicationCore.Enums;

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        /// <summary>
        /// Lấy toàn bộ khách hàng
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        /// CreatedBy: MVThanh(09/01/2021)
        [HttpGet]
        public IActionResult Get()
        {
            var customers = _customerService.GetCustomers();
            return Ok(customers);
        }
        /// <summary>
        /// Thêm mới một khách hàng
        /// </summary>
        /// <param name="customer">object khách hàng</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            var serviceResult = _customerService.AddCustomer(customer);
            if(serviceResult.MISACode == MISACode.NotValid)
            {
                return BadRequest(serviceResult.Data);
            }    
            if(serviceResult.MISACode==MISACode.IsValid && (int)serviceResult.Data>0)
            {
                return Created("add", customer);
            }
            else
            {
                return NoContent();
            }
        }
    }
}
