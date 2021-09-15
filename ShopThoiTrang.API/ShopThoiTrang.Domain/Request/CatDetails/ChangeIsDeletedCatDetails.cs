using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Request.CatDetails
{
    public class ChangeIsDeletedCatDetails
    {
        public int CatDetailsId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
