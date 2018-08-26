using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TieuLuan.Models
{
    [MetadataTypeAttribute(typeof(Employee.EmployeeMetaData))]
    public partial class Employee
    {
        internal sealed class EmployeeMetaData
        {
            [Display(Name ="Employee Code")]
            [Required(ErrorMessage ="Vui lòng nhập mã nhân viên")]
            public string EmployeeCode { get; set; }


            [Display(Name ="Password")]
            [Required(ErrorMessage ="Password là trường bắt buộc nhập")]
            [DataType(DataType.Password)]
            public string EmployeePass { get; set; }

            [Display(Name = "Họ")]
            [Required(ErrorMessage = "Vui lòng nhập họ")]
            public string LastName { get; set; }

            [Display(Name = "Tên")]
            [Required(ErrorMessage = "Vui lòng nhập tên")]
            public string FirstName { get; set; }

            [Display(Name = "Trình độ")]
            [Required(ErrorMessage = "Vui lòng nhập vào trình độ của nhân viên")]
            public string Title { get; set; }

            [Display(Name = "CV")]
            [Required(ErrorMessage = "Mô tả CV")]
            public string TitleOfCourtesy { get; set; }

            [Display(Name = "Ngày sinh")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            [DataType(DataType.Date, ErrorMessage = "Dữ liệu phải là kiểu ngày tháng")]
            [Required(ErrorMessage = "Vui lòng điền ngày sinh")]
            public Nullable<System.DateTime> BirthDate { get; set; }

            [Display(Name = "Ngày bắt đầu làm việc")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            [DataType(DataType.Date, ErrorMessage = "Dữ liệu phải là kiểu ngày tháng")]
            [Required(ErrorMessage = "Vui lòng điền ngày bắt đầu làm việc")]
            public Nullable<System.DateTime> HireDate { get; set; }

            [Display(Name = "Địa chị")]
            [DataType(DataType.MultilineText)]
            [Required(ErrorMessage = "Vui lòng nhập thông tin địa chỉ")]
            public string Address { get; set; }

            [Display(Name = "Mã bưu điện")]
            [DataType(DataType.PostalCode,ErrorMessage ="Mã bưu điện không hợp lệ")]
            [Required(ErrorMessage = "Vui lòng nhập thông tin mã bưu điện")]
            public string PostalCode { get; set; }

            [Display(Name = "Số điện thoại")]
            [DataType(DataType.PhoneNumber,ErrorMessage ="Số điện thoại không hợp lệ")]
            [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
            public string HomePhone { get; set; }


            [Display(Name = "Thông tin khác")]
            public string Extension { get; set; }

            [Display(Name = "Hình Đại Diện")]
            public string EmployeeImg { get; set; }

            [Display(Name = "Ghi chú")]
            [DataType(DataType.MultilineText)]
            [Required(ErrorMessage = "Vui lòng nhập ghi chú")]
            public string Notes { get; set; }

            

            [Display(Name = "Quyền")]
            public Nullable<int> RoleId { get; set; }
        }
    }
 
}