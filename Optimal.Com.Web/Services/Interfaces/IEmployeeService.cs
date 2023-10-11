using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Services
{
    public interface IUserService
    {
        Task<List<UserModel>> GetAllUser();
        Task<UserModel> Create(UserModel model);
        Task<UserAccount?> Update(UserUpdateModel model);
        Task<UserAccount?> GetById(int id);
        Task<UserAccount?> GetByUserId(string UserId);
        Task Delete(int id);
    }
}
