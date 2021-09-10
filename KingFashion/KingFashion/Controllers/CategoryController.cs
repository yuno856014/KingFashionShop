using KingFashion.Commons;
using KingFashion.Helpers;
using KingFashion.Models.Categorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        [Route("/Category/")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/Category/Get")]
        public IActionResult Get()
        {
            var data = ApiHelper.HttpGet<List<Category>>(@$"{Common.ApiUrl}CategoryDetails");
            return Ok(data);
        }
        [HttpGet]
        [Route("/Category/Get/{id}")]
        public IActionResult Get(int id)
        {
            var data = ApiHelper.HttpGet<Category>(@$"{Common.ApiUrl}CategoryDetails/{id}");
            return Ok(data);
        }
        [HttpPost]
        [Route("/Category/Create")]
        public IActionResult Create([FromBody] CreateCategory model)
        {
            return Ok(ApiHelper.HttpPost<CreateCategoryResult>(@$"{Common.ApiUrl}CategoryDetails", "POST", model));
        }
        [HttpPut]
        [Route("/Category/ChangeStatus")]
        public IActionResult ChangeStatus([FromBody] ChangeStatusCategory model)
        {
            return Ok(ApiHelper.HttpPost<ChangeStatusCategoryResult>(@$"{Common.ApiUrl}CategoryDetails/ChangeStatus", "PUT", model));
        }
        [HttpPut]
        [Route("/Category/Update")]
        public IActionResult Update([FromBody] UpdateCategory model)
        {
            return Ok(ApiHelper.HttpPost<UpdateCategoryResult>(@$"{Common.ApiUrl}CategoryDetails", "PUT", model));
        }

        [HttpDelete]
        [Route("/Category/Remove/{id}")]
        public IActionResult Remove(int id)
        {
            return Ok(ApiHelper.HttpGet<DeleteCategoryResult>(@$"{Common.ApiUrl}CategoryDetails/{id}", "DELETE"));
        }
        [HttpPatch]
        [Route("/Category/Restore/{id}")]
        public IActionResult Restore(int id)
        {
            return Ok(ApiHelper.HttpGet<RestoreCategoryResult>(@$"{Common.ApiUrl}CategoryDetails/{id}", "PATCH"));
        }
    }
}
