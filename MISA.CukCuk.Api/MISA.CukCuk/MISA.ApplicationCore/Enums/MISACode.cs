using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Enums
{
    /// <summary>
    /// MISACode xác định trạng thái làm việc của value
    /// </summary>
    public enum MISACode
    {
        /// <summary>
        /// Dữ liệu hợp lệ
        /// </summary>
        IsValid=100,
        /// <summary>
        /// Dữ liệu chưa hợp lệ
        /// </summary>
        NotValid=900,
        /// <summary>
        /// Thành công
        /// </summary>
        Success=200
    }
    /// <summary>
    /// xác định trạng thái của obj
    /// </summary>
    public enum EntityState
    {
        AddNew = 1,
        Update = 2,
        Delete = 3
    }
}
