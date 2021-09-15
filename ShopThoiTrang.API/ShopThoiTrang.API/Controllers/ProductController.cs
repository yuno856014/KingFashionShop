using Microsoft.AspNetCore.Mvc;
using ShopThoiTrang.Domain.Request.Products;
using ShopThoiTrang.Domain.Response.Products;
using ShopThoiTrang.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopThoiTrang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        [Route("{catDetailsId:int}")]
        public async Task<IEnumerable<Product>> Get(int catDetailsId)
        {
            return await productService.Get(catDetailsId);
        }
        [HttpGet]
        [Route("Get/{id:int}")]
        public async Task<Product> GetCatDetailsById(int id)
        {
            return await productService.GetProductById(id);
        }
        [HttpPost]
        public async Task<CreateProductResult> Create(CreateProduct model)
        {
            return await productService.Create(model);
        }
        [HttpPut]
        public async Task<UpdateProductResult> Update(UpdateProduct model)
        {
            return await productService.Update(model);
        }
        [HttpPut]
        [Route("ChangeStatus")]
        public async Task<ChangeStatusProductResult> ChangeStatus(ChangeStatusProduct model)
        {
            return await productService.ChangeStatus(model);
        }
        [HttpPut]
        [Route("ChangeIsDeleted")]
        public async Task<ChangeIsDeletedProductResult> ChangeIsDeleted(ChangeIsDeletedProduct model)
        {
            return await productService.ChangeIsDeleted(model);
        }
    }
}
