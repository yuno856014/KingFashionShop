using KingFashion.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Models.CategoryDetail
{
    public class UpdateCatDetailsResult
    {
        public CategoryDetails Category { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; } 
    }
}
