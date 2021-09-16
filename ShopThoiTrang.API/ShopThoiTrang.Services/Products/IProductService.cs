using ShopThoiTrang.Domain.Request.Products;
using ShopThoiTrang.Domain.Response.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopThoiTrang.Services.Products
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> Get(int productId);
        Task<Product> GetProductById(int productId);
        Task<Product> GetProductByName(string productName, int productId);
        Task<CreateProductResult> Create(CreateProduct create);
        Task<UpdateProductResult> Update(UpdateProduct update);
        Task<ChangeStatusProductResult> ChangeStatus(ChangeStatusProduct model);
        Task<ChangeIsDeletedProductResult> ChangeIsDeleted(ChangeIsDeletedProduct model);

    }
}
