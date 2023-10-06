using AutoMapper;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Models.RequestModels;

namespace Optimal.Com.Web.Startup.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductModel, Product>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
