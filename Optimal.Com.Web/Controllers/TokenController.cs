using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Commons;
using Optimal.Com.Web.Framework.Entity;
using Optimal.Com.Web.Framework.Repository;
using Optimal.Com.Web.Framework.Services.Interface;
using Optimal.Com.Web.Models.RequestModels;
using Optimal.Com.Web.Models.ResponseModels;
using Optimal.Com.Web.Services;

namespace Optimal.Com.Web.Controllers
{
    public class TokenController : BaseController
    {
        private readonly IJwtTokenService _jwtTokenService;
        private readonly IUserAccountService _userAccountService;
        public TokenController( 
            IJwtTokenService jwtTokenService,
            IUserAccountService userAccountService) 
        {
            _jwtTokenService = jwtTokenService;
            _userAccountService = userAccountService;
        }
        [HttpPost]
        public async Task<IActionResult> Authenticate(LoginModel model)
        {
            var user = await _userAccountService.GetUserLogin(model.LoginName, model.Password);
            if (user == null)
            {
                return Ok(new ApiResponse
                {
                    Success = false,
                    Message = "Invalid LoginName/Password"
                }); 
            }
            return Ok(new ApiResponse
            {
                Success = true,
                Message ="Authenticate Successfully",
                Data = _jwtTokenService.GetNewJwtToken(user)
            });
        } 
    }
}
