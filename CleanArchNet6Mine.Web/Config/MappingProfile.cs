using AutoMapper;
using CleanArchNet6Mine.Infrastructure.Models;
using CleanArchNet6Mine.Web.ApiModels;

namespace CleanArchNet6Mine.Web.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDescription, ProductDescriptionDto>();
        }
    }
}
