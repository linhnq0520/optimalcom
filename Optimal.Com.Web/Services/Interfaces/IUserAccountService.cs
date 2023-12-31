﻿using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Entity;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Services
{
    public interface IUserAccountService
    {
        Task<List<UserAccount>> GetAllUser();

        Task<UserAccountModel> Create(UserAccountModel model);

        Task<UserAccount> Update(UserUpdateModel model);

        Task<UserAccount> GetById(int id);

        Task<UserAccount> GetByUserCode(string userCode);

        Task Delete(int id);

        Task<User> GetUserLogin(string loginName, string password);
    }
}
