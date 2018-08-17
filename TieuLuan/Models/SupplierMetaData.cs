using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TieuLuan.Models
{
    [MetadataTypeAttribute(typeof(Supplier.SupplierMetadata))]
    public partial class Supplier
    {
        internal sealed class SupplierMetadata
        {
            [Display(Name = "Nhà Cung Cấp")]
            public int SupplierId { get; set; }
            [Display(Name = "Nhà Cung Cấp")]
            public string CompanyName { get; set; }
            [Display(Name = "Người đại diện")]
            public string ContactName { get; set; }
            [Display(Name = "Nội dung")]
            public string ContactTitle { get; set; }
            [Display(Name = "Địa chỉ")]
            public string Address { get; set; }
            [Display(Name = "Số điện thoại")]
            public string Phone { get; set; }
            [Display(Name = "Fax")]
            public string Fax { get; set; }
            [Display(Name = "Trang Chủ")]
            public string HomePage { get; set; }
        }
    }

}