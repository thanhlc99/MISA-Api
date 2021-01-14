using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.ApplicationCore.Models
{
    // <summary>
    /// Khách hàng
    /// </summary>
    /// CreateBy: mvthanh(23/11/2020)
    public class Customer:BaseEntiy
    {
        #region Declare
        #endregion

        #region Constructor
        #endregion

        #region property
        /// <summary>
        /// khóa chính
        /// </summary>
        [PrimaryKey]
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        [CheckDuplicate]
        [Required]
        [DisplayName("mã khách hàng")]
        [MaxLength(20,"mã khách hàng không được quá 20 ký tự!")]
        public string CustomerCode { get; set; }
        /// <summary>
        /// họ và tên đầy đủ
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Mã thẻ khách hàng
        /// </summary>
        public string MemberCardCode { get; set; }
        /// <summary>
        /// mã khóa ngoại bảng customer group
        /// </summary>
        public Guid CustomerGroupId { get; set; }
        /// <summary>
        /// Ngày tháng năm sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// địa chỉ email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// tên công ty
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// mã số thuế công ty
        /// </summary>
        public string CompanyTaxCode { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }
       
        #endregion

        #region Method
        #endregion

    }
}
