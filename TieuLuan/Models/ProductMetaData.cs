using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TieuLuan.Models
{
[MetadataTypeAttribute(typeof(Products.ProductMetaData))]
    public partial class Products
    {
        internal sealed class ProductMetaData
        {
           
        }
    }
}