using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Request.Products
{
    public class ChangeStatusProduct
    {
        public int ProductId { get; set; }
        public bool Status { get; set; }
    }
}
