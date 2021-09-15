using KingFashion.Commons;
using KingFashion.Helpers;
using KingFashion.Models.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingFashion.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("/Product/{catDetailsId}")]
        public async Task<IActionResult> Index(int catDetailsId)
        {
            ViewBag.CatDetailsId = catDetailsId;
            var data = await ApiHelper.HttpGet<List<Product>>(@$"{Common.ApiUrl}Product/{catDetailsId}");
            return View(data);
        }
        [HttpGet]
        [Route("/Product/Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await ApiHelper.HttpGet<Product>(@$"{Common.ApiUrl}Product/Get/{id}");
            return Ok(data);
        }
        [HttpPut]
        [Route("/Product/ChangeStatus")]
        public async Task<IActionResult> ChangeStatus([FromBody] ChangeStatusProduct model)
        {
            return Ok(await ApiHelper.HttpPost<ChangeStatusProductResult>(@$"{Common.ApiUrl}Product/ChangeStatus", "PUT", model));
        }
        [HttpPut]
        [Route("/Product/ChangeIsDeleted")]
        public async Task<IActionResult> ChangeIsDeleted([FromBody] ChangeIsDeletedProduct model)
        {
            return Ok(await ApiHelper.HttpPost<ChangeIsDeletedProductResult>(@$"{Common.ApiUrl}Product/ChangeIsDeleted", "PUT", model));
        }
        [HttpPost]
        [Route("/Product/{catDetailsId}/Create")]
        public async Task<IActionResult> Create([FromBody] CreateProduct model)
        {
            return Ok(await ApiHelper.HttpPost<CreateProductResult>(@$"{Common.ApiUrl}Product", "POST", model));
        }
        [HttpPut]
        [Route("/Product/Update")]
        public async Task<IActionResult> Update([FromBody] UpdateProduct model)
        {
            return Ok(await ApiHelper.HttpPost<UpdateProductResult>(@$"{Common.ApiUrl}Product", "PUT", model));
        }
    }
}
