using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Request.Products
{
    public class ChangeIsDeletedProduct
    {
        public int ProductId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
