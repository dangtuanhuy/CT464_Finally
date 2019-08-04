using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TieuLuan.Models
{
    [MetadataTypeAttribute(typeof(About.AboutMetaData))]
    public partial class About
    {
        internal sealed class AboutMetaData
        {
            public int AboutId { get; set; }

            [Display(Name = "Về Chúng Tôi")]
            [Required(ErrorMessage = "Bắt buộc phải điền")]
            public string AboutUs { get; set; }

            public string AboutImg { get; set; }

            [Display(Name = "Chi Tiết")]
            [Required(ErrorMessage = "Bắt buộc phải điền")]
            public string AboutDetails { get; set; }


            public string EmployeeCode { get; set; }
        }
    }
}