using KingFashion.Models.Categorys;
using KingFashion.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Models.CategoryDetail
{
    public class CategoryDetails
    {
        public int CatDetailsId { get; set; }
        public string CatDetailsName { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
        public Categorys.Category Category { get; set; }
        public ICollection<Product> Product { get; set; } 
        public int CategoryId { get; set; }
    }
}
