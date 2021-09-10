using KingFashion.Models.Categorys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Models.CategoryDetail
{
    public class CategoryDetails
    { 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
