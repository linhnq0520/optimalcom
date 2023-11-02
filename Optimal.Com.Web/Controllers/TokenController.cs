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

namespace Optimal.Com.Web.Controllers
{
    public class TokenController : BaseController
    {
        private readonly IRepository<UserAccount> _userRepository;
        private readonly IJwtTokenService _jwtTokenService;
        private readonly IMapper _mapper;
        public TokenController(IRepository<UserAccount> userRepository, 
            IJwtTokenService jwtTokenService,
            IMapper mapper) 
        {
            _userRepository = userRepository;
            _jwtTokenService = jwtTokenService;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Authenticate(LoginModel model)
        {
            var userAccount = await _userRepository.Table.Where(s => s.LoginName == model.LoginName && s.Password == model.Password)
                                            .SingleOrDefaultAsync();
            if (userAccount == null)
            {
                return Ok(new ApiResponse
                {
                    IsSuccess = false,
                    Message = "Invalid LoginName/Password"
                }); 
            }
            var user = _mapper.Map<User>(userAccount);
            return Ok(new ApiResponse
            {
                IsSuccess = true,
                Message ="Authenticate Successfully",
                Data = _jwtTokenService.GetNewJwtToken(user)
            });
        } 
    }
}
