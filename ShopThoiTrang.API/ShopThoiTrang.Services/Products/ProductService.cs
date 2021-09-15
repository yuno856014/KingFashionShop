using Dapper;
using Microsoft.Extensions.Configuration;
using ShopThoiTrang.Domain.Request.Products;
using ShopThoiTrang.Domain.Response.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ShopThoiTrang.Services.Products
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<ChangeIsDeletedProductResult> ChangeIsDeleted(ChangeIsDeletedProduct model)
        {
            try
            {
                var foundProduct = await GetProductById(model.ProductId);

                if (foundProduct != null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@productId", model.ProductId);
                    parameters.Add("@isDeleted", model.IsDeleted);

                    var productId = await SqlMapper.QueryFirstOrDefaultAsync<int>(
                                            cnn: connection,
                                            sql: "sp_ChangeIsDeletedProduct",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure
                                        );
                    return new ChangeIsDeletedProductResult()
                    {
                        Success = productId > 0
                    };
                }
                return new ChangeIsDeletedProductResult()
                {
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ChangeIsDeletedProductResult()
                {
                    Success = false
                };
            }

        }

        public async Task<ChangeStatusProductResult> ChangeStatus(ChangeStatusProduct model)
        {
            try
            {
                var foundProduct = await GetProductById(model.ProductId);

                if (foundProduct != null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@productId", model.ProductId);
                    parameters.Add("@status", model.Status);

                    var productId = await SqlMapper.QueryFirstOrDefaultAsync<int>(
                                            cnn: connection,
                                            sql: "sp_ChangeStatusProduct",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure
                                        );
                    return new ChangeStatusProductResult()
                    {
                        Success = productId > 0
                    };
                }
                return new ChangeStatusProductResult()
                {
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ChangeStatusProductResult()
                {
                    Success = false
                };
            }
        }

        public async Task<CreateProductResult> Create(CreateProduct create)
        {
            try
            {
                var foundProduct = await GetProductByName(create.ProductName);
                if (foundProduct == null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@productName", create.ProductName);
                    parameters.Add("@status", create.Status);
                    parameters.Add("@isDeleted", create.IsDeleted);
                    parameters.Add("@photo", create.Photo);
                    parameters.Add("@price", create.Price);
                    parameters.Add("@quantity", create.Quantity);
                    parameters.Add("@productCode", create.ProductCode);
                    parameters.Add("@color", create.Color);
                    parameters.Add("@desciption", create.Description);
                    parameters.Add("@size", create.Size);
                    parameters.Add("@catDetailsId", create.CatDetailsId);
                    var product = await SqlMapper.QueryFirstOrDefaultAsync<Product>(cnn: connection, sql: "sp_CreateProduct", param: parameters, commandType: CommandType.StoredProcedure);
                    return new CreateProductResult()
                    {
                        IsExitst = false,
                        Product = product
                    };
                }
                return new CreateProductResult()
                {
                    Product = foundProduct,
                    IsExitst = true
                };

            }
            catch (Exception ex)
            {
                return new CreateProductResult()
                {
                    Product = new Product()
                };
            }
        }


        public async Task<IEnumerable<Product>> Get(int catDetailsId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@catDetailsId", catDetailsId);
            var product = await SqlMapper.QueryAsync<Product>(cnn: connection, sql: "sp_GetAllProductById", param: parameters, commandType: CommandType.StoredProcedure);
            return product;
        }

        public async Task<Product> GetProductById(int productId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@productId", productId);
            var product = await SqlMapper.QueryFirstOrDefaultAsync<Product>(cnn: connection, sql: "sp_GetProductById", param: parameters, commandType: CommandType.StoredProcedure);
            return product;
        }

        public async Task<Product> GetProductByName(string productName, int productId = 0)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@productName", productName);
            parameters.Add("@productId", productId);
            var product = await SqlMapper.QueryFirstOrDefaultAsync<Product>(cnn: connection, sql: "sp_GetProductByName", param: parameters, commandType: CommandType.StoredProcedure);
            return product;
        }
  
        public async Task<UpdateProductResult> Update(UpdateProduct update)
        {
            try
            {
                var foundproduct = await GetProductByName(update.ProductName, update.ProductId);
                if (foundproduct == null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@productId", update.ProductId);
                    parameters.Add("@productName", update.ProductName);
                    parameters.Add("@status", update.Status);
                    parameters.Add("@isDeleted", update.IsDeleted);
                    parameters.Add("@photo", update.Photo);
                    parameters.Add("@price", update.Price);
                    parameters.Add("@quantity", update.Quantity);
                    parameters.Add("@productCode", update.ProductCode);
                    parameters.Add("@color", update.Color);
                    parameters.Add("@desciption", update.Description);
                    parameters.Add("@size", update.Size);
                    var product = await SqlMapper.QueryFirstOrDefaultAsync<Product>(cnn: connection, sql: "sp_UpdateProduct", param: parameters, commandType: CommandType.StoredProcedure);
                    return new UpdateProductResult()
                    {
                        IsExitst = false,
                        Product = product
                    };
                }
                else
                {
                    return new UpdateProductResult()
                    {
                        Product = foundproduct,
                        IsExitst = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new UpdateProductResult();
            };
        }
    }
}
