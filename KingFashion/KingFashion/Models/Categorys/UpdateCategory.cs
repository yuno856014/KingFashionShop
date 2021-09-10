using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Models.Categorys
{
    public class UpdateCategory
    {
        public int CatDetailsId { get; set; }
        public string CatDetailsName { get; set; }
        public bool Status { get; set; }
    }
}
