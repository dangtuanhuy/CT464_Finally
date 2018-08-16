using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TieuLuan.Models
{
    [MetadataTypeAttribute(typeof(Category.CategoryMetaData))]
    public partial class Category
    {
        internal sealed class CategoryMetaData
        {
            [Display(Name="Danh Mục")]
            public int CategoryId { get; set; }
            
            [Display(Name="Tên Danh Mục")]
            [Required(ErrorMessage="Tên Danh Mục không được để rỗng")]
            public string CategoryName { get; set; }
            [Display(Name="Mô tả")]
            [Required(ErrorMessage = "Mô tả về danh mục không được để rỗng")]
            public string CategoryDetails { get; set; }
    
        }
    }
   
}