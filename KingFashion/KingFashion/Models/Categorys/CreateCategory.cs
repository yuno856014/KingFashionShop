using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Models.Categorys
{
    public class CreateCategory
    {
        public string CatDetailsName { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
    }
}
