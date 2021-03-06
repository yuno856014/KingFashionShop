using ShopThoiTrang.Domain.Request.CatDetails;
using ShopThoiTrang.Domain.Response.CatDetails;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopThoiTrang.Services.CatDetailsService
{
    public interface ICategoryDetailsService
    {
        Task<IEnumerable<CategoryDetails>> Get(int catId);
        Task<CategoryDetails> GetCatDetailsById(int catDetailsId);
        Task<CategoryDetails> GetCatDetailsByName(string catDetailsName, int catDetailsId);
        Task<CreateCatDetailsResult> Create(CreateCatDetails create);
        Task<UpdateCatDetailsResult> Update(UpdateCatDetails update);
        Task<ChangeStatusCategoryDetailsResult> ChangeStatus(ChangeStatusCategoryDetails model);
        Task<ChangeIsDeletedCatDetailsResult> ChangeIsDeleted(ChangeIsDeletedCatDetails model);

    }
}
