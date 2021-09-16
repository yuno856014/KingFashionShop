using KingFashion.Models.CategoryDetail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Models.Products
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
