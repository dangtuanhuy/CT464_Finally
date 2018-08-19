using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TieuLuan.Models
{
    [MetadataTypeAttribute(typeof(Delivery.DeliveryMetaData))]
    public partial class Delivery
    {
        internal sealed class DeliveryMetaData
        {
            public int DeliveryId { get; set; }

            [Required(ErrorMessage="Trường bắt buộc phải nhập")]
            [Display(Name="Tiêu Đề")]
            public string DeliveryTitle { get; set; }

            [Required(ErrorMessage = "Trường bắt buộc phải nhập")]
            [Display(Name="Chi Tiết")]
            public string DeliveryDetails { get; set; }

            [Required(ErrorMessage = "Trường bắt buộc phải nhập")]
            [Display(Name="Câu Hỏi Thường Gặp")]
            public string DeliveryQuestion { get; set; }

         
            public string DeliveryImg { get; set; }

            public string EmployeeCode { get; set; }
        }
    }
}