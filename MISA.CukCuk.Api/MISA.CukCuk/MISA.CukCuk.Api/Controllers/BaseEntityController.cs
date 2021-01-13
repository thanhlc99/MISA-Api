using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Enums;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseEntityController<TEntity> : ControllerBase
    {
        IBaseService<TEntity> _baseService;

        public BaseEntityController(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// Lấy toàn bộ
        /// </summary>
        /// <returns>Danh sách</returns>
        /// CreatedBy: MVThanh(09/01/2021)
        [HttpGet]
        public IActionResult Get()
        {
            var customers = _baseService.GetEntities();
            return Ok(customers);
        }

        /// <summary>
        /// Thêm mới
        /// </summary>
        /// <param name="customer">object</param>
        /// <returns>200</returns>
        /// CreatedBy: MVThanh(12/01/2021)
        [HttpPost]
        public IActionResult Post(TEntity entity)
        {
            var serviceResult = _baseService.Add(entity);
            return Ok();
        }

        /// <summary>
        /// lấy ra theo mã id
        /// </summary>
        /// <param name="id">khóa chính</param>
        /// <returns>một obj</returns>
        /// createdBy MVThanh(12/01/2021)
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var entity = _baseService.GetEntityById(Guid.Parse(id));
            return Ok(entity);
        }
    }
}
