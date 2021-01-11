﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Entity
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
}