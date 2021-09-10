using KingFashion.Commons;
using KingFashion.Helpers;
using KingFashion.Models.CategoryDetail;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Controllers
{
    public class CategoryDetailsController : Controller
    {
        public IActionResult Index()
        {
            var data = ApiHelper.HttpGet<List<CategoryDetails>>(@$"{Common.ApiUrl}Category");
            return View(data);
        }
    }
}
