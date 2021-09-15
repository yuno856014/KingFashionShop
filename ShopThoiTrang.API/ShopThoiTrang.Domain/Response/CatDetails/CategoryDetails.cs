using ShopThoiTrang.Domain.Response.Categories;
using ShopThoiTrang.Domain.Response.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Response.CatDetails
{
    public class CategoryDetails
    {
        public int CatDetailsId { get; set; }
        public string CatDetailsName { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
