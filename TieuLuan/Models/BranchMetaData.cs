using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TieuLuan.Models
{
    [MetadataTypeAttribute(typeof(Branch.BranchMetaData))]
    public partial class Branch
    {
        internal sealed class BranchMetaData
        {
            public int BranchId { get; set; }

            [Display(Name = "Tên Chi Nhánh")]
            [Required(ErrorMessage = "Bắt buộc phải điền")]
            public string BranchName { get; set; }

            [Display(Name = "Chi Tiết")]
            [Required(ErrorMessage = "Bắt buộc phải điền")]
            public string BranchDetails { get; set; }

            [Display(Name = "Nhân Viên")]
            [Required(ErrorMessage = "Bắt buộc phải điền")]
            public string EmployeeCode { get; set; }
        }
    }
}