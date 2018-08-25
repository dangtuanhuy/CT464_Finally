using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TieuLuan.Models
{
    [MetadataTypeAttribute(typeof(Promotion.PromotionMetaData))]
    public partial class Promotion
    {
        internal sealed class PromotionMetaData
        {
            public int PromotionId { get; set; }


            [Display(Name = "Tên Khuyến Mãi")]
            [Required(ErrorMessage ="Tên khuyến mãi là bắt buộc nhập")]
            public string PromotionName { get; set; }


            [Display(Name = "Chi Tiết Khuyến Mãi")]
            [DataType(DataType.MultilineText)]
            [Required(ErrorMessage ="Vui lòng nhập chi tiết khuyến mãi")]
            public string PromotionDetails { get; set; }

            [Display(Name = "Giảm")]
            [Required(ErrorMessage ="Vui lòng nhập giảm giá của chương trình khuyến mãi này")]
            public Nullable<int> PromotionDiscount { get; set; }
            [Display(Name = "Trạng Thái")]
            [Required(ErrorMessage ="Vui lòng chọn trạng thái")]
            public Nullable<bool> PromotionStatus { get; set; }


            [Display(Name = "Ngày Bắt đầu")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            [DataType(DataType.Date,ErrorMessage ="Dữ liệu phải là kiểu ngày tháng")]
            [Required(ErrorMessage = "Vui lòng điền ngày bắt đầu")]
            public Nullable<System.DateTime> PromotionOpen { get; set; }
            [Display(Name = "Ngày Kết Thúc")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            [DataType(DataType.Date, ErrorMessage = "Dữ liệu phải là kiểu ngày tháng")]
            [Required(ErrorMessage = "Vui lòng điền ngày kết thúc")]
            public Nullable<System.DateTime> PromotionClose { get; set; }
        }
    }
    
}