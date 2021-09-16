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
        
        [HttpGet]
        [Route("/CategoryDetails/{categoryId}")]
        public async Task<IActionResult> Index(int categoryId)
        {
               ViewBag.CatId = categoryId;
               var data = await ApiHelper.HttpGet<List<CategoryDetails>>(@$"{Common.ApiUrl}CategoryDetails/{categoryId}");
            return View(data);
        }
        [HttpGet]   
        [Route("/CategoryDetails/Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await ApiHelper.HttpGet<CategoryDetails>(@$"{Common.ApiUrl}CategoryDetails/Get/{id}");
            return Ok(data);
        }
        [HttpPost]
        [Route("/CategoryDetails/{categoryId}/Create")]
        public async Task<IActionResult> Create([FromBody] CreateCatDetails model)
        {
            return Ok(await ApiHelper.HttpPost<CreateCateDetailsResult>(@$"{Common.ApiUrl}CategoryDetails", "POST", model));
        }
        [HttpPut]
        [Route("/CategoryDetails/ChangeStatus")]
        public async Task<IActionResult> ChangeStatus([FromBody] ChangeStatusCatDetails model)
        {
            return Ok(await ApiHelper.HttpPost<ChangeStatusCatDetailsResult>(@$"{Common.ApiUrl}CategoryDetails/ChangeStatus", "PUT", model));
        }
        [HttpPut]
        [Route("/CategoryDetails/Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCatDetails model)
        {
            return Ok(await ApiHelper.HttpPost<UpdateCatDetailsResult>(@$"{Common.ApiUrl}CategoryDetails", "PUT", model));
        }
        [HttpPut]
        [Route("/CategoryDetails/ChangeIsDeleted")]
        public async Task<IActionResult> ChangeIsDeleted([FromBody] ChangeIsDeletedCatDetails model)
        {
            return Ok(await ApiHelper.HttpPost<ChangeIsDeletedCatDetailsResult>(@$"{Common.ApiUrl}CategoryDetails/ChangeIsDeleted", "PUT", model));
        }
    }
}
