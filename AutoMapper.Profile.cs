using AutoMapper;

namespace AutoMapperTutorial
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SuperModel, HeroDto>();
            CreateMap<HeroDTO, SuperModel>();
        }
    }
}