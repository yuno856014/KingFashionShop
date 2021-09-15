using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopThoiTrang.Domain.Request.CatDetails;
using ShopThoiTrang.Domain.Response.CatDetails;
using ShopThoiTrang.Services.CatDetailsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopThoiTrang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryDetailsController : ControllerBase
    {
        private readonly ICategoryDetailsService categoryDetailsService;

        public CategoryDetailsController(ICategoryDetailsService categoryDetailsService)
        {
            this.categoryDetailsService = categoryDetailsService;
        }
        [HttpGet]
        [Route("{catId:int}")]
        public async Task<IEnumerable<CategoryDetails>> Get(int catId)
        {
            return await categoryDetailsService.Get(catId);
        }
        [HttpGet]
        [Route("Get/{id:int}")]
        public async Task<CategoryDetails> GetCatDetailsById(int id)
        {
            return await categoryDetailsService.GetCatDetailsById(id);
        }
        [HttpPost]
        public async Task<CreateCatDetailsResult> Create(CreateCatDetails model)
        {
            return await categoryDetailsService.Create(model);
        }
        [HttpPut]
        public async Task<UpdateCatDetailsResult> Update(UpdateCatDetails model)
        {
            return await categoryDetailsService.Update(model);
        }
        [HttpPut]
        [Route("ChangeStatus")]
        public async Task<ChangeStatusCategoryDetailsResult> ChangeStatus(ChangeStatusCategoryDetails model)
        {
            return await categoryDetailsService.ChangeStatus(model);
        }
        [HttpPut]
        [Route("ChangeIsDeleted")]
        public async Task<ChangeIsDeletedCatDetailsResult> ChangeIsDeleted(ChangeIsDeletedCatDetails model)
        {
            return await categoryDetailsService.ChangeIsDeleted(model);
        }
    }
}
