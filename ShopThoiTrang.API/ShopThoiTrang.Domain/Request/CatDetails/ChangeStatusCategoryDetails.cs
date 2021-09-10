using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Request.CatDetails
{
    public class ChangeStatusCategoryDetails
    {
        public int CatDetailsId { get; set; }
        public bool Status { get; set; }
    }
}
