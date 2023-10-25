using AutoMapper;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Startup.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserAccount, UserAccountModel>();

            CreateMap<UserAccountModel, UserAccount>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<UserUpdateModel, UserAccount>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.UserID, opt => opt.Ignore());
        }
    }
}
