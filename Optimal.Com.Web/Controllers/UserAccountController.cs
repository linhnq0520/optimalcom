using Microsoft.AspNetCore.Mvc;
using Optimal.Com.Web.Framework.Controller;
using Optimal.Com.Web.Models.RequestModels;
using Optimal.Com.Web.Services;

namespace Optimal.Com.Web.Controllers
{
    public class UserController:BaseController
    {
        private readonly IUserService _UserService;
        public UserController(IUserService UserService)
        {
            _UserService = UserService;
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(UserModel model)
        {
            var response = await _UserService.Create(model);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _UserService.GetAllUser();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UserUpdateModel model)
        {
            var respone = await _UserService.Update(model);
            return Ok(respone);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _UserService.GetById(id);
            if (response != null)
                return Ok(response);
            else
                return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetByUserId(string UserId)
        {
            var response = await _UserService.GetByUserId(UserId);
            if (response != null)
                return Ok(response);
            else
                return NotFound();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteById(int id)
        {
            var emp = await _UserService.GetById(id);
            if(emp != null)
            {
                await _UserService.Delete(id);
                return Ok();
            }
            else return NotFound();
        }
    }
}
