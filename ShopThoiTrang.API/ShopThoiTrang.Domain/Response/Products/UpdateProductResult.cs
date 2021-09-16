using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Response.Products
{
    public class UpdateProductResult
    {
        public Product Product { get; set; }
        public bool IsExitst { get; set; }
        public bool Success => Product != null && Product.ProductId > 0 && !IsExitst;
        public string Message => Success ? Common.Message.Product.Update : (IsExitst ? Common.Message.Product.Exits : Common.Message.Fail);
    }
}
