using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Response.CatDetails
{
    public class ChangeIsDeletedCatDetailsResult
    {
        public bool Success { get; set; }
        public string Message => Success ? Common.Message.CategoryDetails.ChangeIsDeleted : Common.Message.Fail;
    }
}
