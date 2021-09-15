using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Request.Products
{
    public class UpdateProduct
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
        public string ProductCode { get; set; }
    }
}
