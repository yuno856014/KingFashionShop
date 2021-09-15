using KingFashion.Models.CategoryDetail;
using KingFashion.Models.Categorys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Models.Categorys
{
    public class Category
    { 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<CategoryDetails> CategoryDetails { get; set; }
    }
}
