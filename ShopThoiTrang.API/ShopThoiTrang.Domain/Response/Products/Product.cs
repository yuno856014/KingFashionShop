using ShopThoiTrang.Domain.Response.CatDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopThoiTrang.Domain.Response.Products
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public int Quantity { get; set; }
        [MaxLength(10)]
        public string ProductCode { get; set; }
        public CategoryDetails categoryDetails { get; set; }
        public int CatDetailsId { get; set; } 
    }
}
