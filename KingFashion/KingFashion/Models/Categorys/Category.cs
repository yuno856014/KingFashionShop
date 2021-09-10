using KingFashion.Models.CategoryDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Models.Categorys
{
    public class Category
    {
        public int CatDetailsId { get; set; }
        public string CatDetailsName { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public CategoryDetails CategoryDetails { get; set; }
        
    }
}
