using ShopThoiTrang.Domain.Response.CatDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Response.Categories
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<CategoryDetails> CategoryDetails { get; set; }
    }
}
