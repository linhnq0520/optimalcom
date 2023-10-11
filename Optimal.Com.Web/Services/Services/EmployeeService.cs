using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Data;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserAccount> _UserRepository;
        private readonly IMapper _mapper;
        public UserService(IRepository<UserAccount> UserRepository, IMapper mapper) 
        { 
            _UserRepository = UserRepository;
            _mapper = mapper;
        }
        public async Task<List<UserModel>> GetAllUser()
        {
            var response = new List<UserModel>();
            var emps = await _UserRepository.Table.ToListAsync();
            if(emps.Any())
            {
                response = _mapper.Map<List<UserModel>>(emps);
            }
            return response;
        }
        public async Task<UserModel> Create(UserModel model)
        {
            if (!string.IsNullOrEmpty(model.Email) && !Utils.Utils.IsValidEmail(model.Email))
            {
                throw new Exception("Invalid email");
            }
            var entity = _mapper.Map<UserAccount>(model);
            await _UserRepository.AddAsync(entity);
            return model;
        }

        public async Task<UserAccount?> GetById(int id)
        {
            var emp = await _UserRepository.GetByIdAsync(id)??null;
            return emp;
        }

        public async Task<UserAccount?> GetByUserId(string UserId)
        {
            var emp = await _UserRepository.Table.Where(s => s.UserID == UserId).FirstOrDefaultAsync();
            return emp;
        }

        public async Task<UserAccount?> Update(UserUpdateModel model)
        {
            if (!string.IsNullOrEmpty(model.Email) && !Utils.Utils.IsValidEmail(model.Email))
            {
                throw new Exception("Invalid email");
            }

            var emp = await _UserRepository.GetByIdAsync(model.Id);

            if (emp != null)
            {
                var updatedEntity = _mapper.Map(model, emp);
                await _UserRepository.UpdateAsync(updatedEntity);
            }
            else
            {
                var enity = _mapper.Map<UserAccount>(model);
                await _UserRepository.AddAsync(enity);
            }

            return await GetById(model.Id);
        }

        public async Task Delete(int id)
        {
            await _UserRepository.DeleteAsync(id);
        }

    }
}
