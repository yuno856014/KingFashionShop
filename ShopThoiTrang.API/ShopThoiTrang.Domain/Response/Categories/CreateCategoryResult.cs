using System;
using System.Collections.Generic;
using System.Text;

namespace ShopThoiTrang.Domain.Response.Categories
{
    public class CreateCategoryResult
    {
        public Category Category { get; set; }
        public bool IsExitst { get; set; }
        public bool Success => Category != null && Category.CategoryId > 0 && !IsExitst;
        public string Message => Success ? Common.Message.Category.Create : (!IsExitst ? Common.Message.Category.Exits : Common.Message.Fail);
    }
}
