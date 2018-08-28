using System.ComponentModel.DataAnnotations;
namespace TieuLuan.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Tên đăng nhập không được rỗng")]
        public string EmployeeCode { get; set; }
        [Required(ErrorMessage = "Tên đăng nhập không được rỗng")]
        public string EmployeePass { get; set; }
    }
}