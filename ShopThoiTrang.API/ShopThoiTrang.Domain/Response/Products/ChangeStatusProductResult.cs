using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Response.Products
{
    public class ChangeStatusProductResult
    {
        public bool Success { get; set; }
        public string Message => Success ? Common.Message.Product.ChangeStatus : Common.Message.Fail;
    }
}
