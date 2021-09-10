using KingFashion.Commons;
using KingFashion.Helpers;
using KingFashion.Models.CategoryDetail;
using KingFashion.Models.Categorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Controllers
{
    public class CategoryDetailsController : Controller
    {
        // GET: CategoryController
        [HttpGet]
        [Route("/CategoryDetails/")]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        [Route("/CategoryDetails/{Id}")]
        public IActionResult GetById(int Id)
        {
            var data = ApiHelper.HttpGet<List<CategoryDetails>>(@$"{Common.ApiUrl}CategoryDetails/{Id}");
            return Ok(data);
        }
        [HttpGet]
        [Route("/CategoryDetails/Get/{id}")]
        public IActionResult Get(int id)
        {
            var data = ApiHelper.HttpGet<CategoryDetails>(@$"{Common.ApiUrl}CategoryDetails/Get/{id}");
            return Ok(data);
        }
        [HttpPost]
        [Route("/CategoryDetails/Create")]
        public IActionResult Create([FromBody] CreateCatDetails model)
        {
            return Ok(ApiHelper.HttpPost<CreateCateDetailsResult>(@$"{Common.ApiUrl}CategoryDetails", "POST", model));
        }
        [HttpPut]
        [Route("/CategoryDetails/ChangeStatus")]
        public IActionResult ChangeStatus([FromBody] ChangeStatusCateDetails model)
        {
            return Ok(ApiHelper.HttpPost<ChangeStatusCatDetails>(@$"{Common.ApiUrl}CategoryDetails/ChangeStatus", "PUT", model));
        }
        [HttpPut]
        [Route("/CategoryDetails/Update")]
        public IActionResult Update([FromBody] UpdateCatDetails model)
        {
            return Ok(ApiHelper.HttpPost<UpdateCatDetailsResult>(@$"{Common.ApiUrl}CategoryDetails", "PUT", model));
        }

        [HttpDelete]
        [Route("/CategoryDetails/Remove/{id}")]
        public IActionResult Remove(int id)
        {
            return Ok(ApiHelper.HttpGet<DeleteCatDetailsResult>(@$"{Common.ApiUrl}CategoryDetails/{id}", "DELETE"));
        }
        [HttpPatch]
        [Route("/CategoryDetails/Restore/{id}")]
        public IActionResult Restore(int id)
        {
            return Ok(ApiHelper.HttpGet<RestoreCatDetailsResult>(@$"{Common.ApiUrl}CategoryDetails/{id}", "PATCH"));
        }
    }
}
