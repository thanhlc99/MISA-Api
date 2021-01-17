using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Models
{
    /// <summary>
    /// Bảng nhân viên
    /// </summary>
    /// createdBy: MVThanh(12/01/2021)
    public class Employee
    {
        #region Declare
        #endregion

        #region Constructor
        #endregion

        #region property
        /// <summary>
        /// khóa chính
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }
        /// <summary>
        /// tên đầy đủ nhân viên
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// ngày tháng năm sinh
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// giới tính
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// Số chứng minh nhân dân/ thẻ căn cước
        /// </summary>
        public string IdentityCardNumber { get; set; }
        /// <summary>
        /// Ngày cấp thẻ chứng minh thư nhân dân/căn cước
        /// </summary>
        public DateTime LevelDate { get; set; }
        /// <summary>
        /// Nơi cấp chứng minh thư nhân dân/căn cước
        /// </summary>
        public string PlaceOfIssue { get; set; }
        /// <summary>
        /// địa chỉ email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// số điện thoại nhân viên
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Vị trí làm việc trong công ty
        /// </summary>
        public string PositionName { get; set; }
        /// <summary>
        /// Tên phòng ban làm việc
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// Mã số thuế cá nhân
        /// </summary>
        public string PersonalTaxCode { get; set; }
        /// <summary>
        /// Mức lương cơ bản
        /// </summary>
        public float Salary { get; set; }
        /// <summary>
        /// ngày gia nhập
        /// </summary>
        public DateTime JoinDate { get; set; }
        /// <summary>
        /// tình trạng công việc
        /// </summary>
        public string JobStatus { get; set; }
        /// <summary>
        /// ngày khởi tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Người khởi tạo
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Ngày sửa
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Người sửa
        /// </summary>
        public string ModifiedBy { get; set; }
        #endregion

        #region Method
        #endregion

    }
}
