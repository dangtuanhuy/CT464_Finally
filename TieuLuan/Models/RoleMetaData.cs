using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TieuLuan.Models
{
    [MetadataTypeAttribute(typeof(Role.RoleMetaData))]
    public partial class Role
    {
        internal sealed class RoleMetaData
        {
            [Display(Name ="Quyền")]
            public int Id { get; set; }
            [Display(Name = "Quyền Truy Cập")]
            [Required(ErrorMessage = "Vui lòng nhập quyền")]
            public string RoleName { get; set; }

            [Display(Name = "Mô tả")]
            [Required(ErrorMessage ="Vui lòng nhập vào mô tả quyền")]
            [DataType(DataType.MultilineText)]
            public string RoleDescription { get; set; }
        }
    }
   
}