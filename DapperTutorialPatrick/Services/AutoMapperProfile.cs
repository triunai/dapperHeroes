using AutoMapper;
using DapperTutorialPatrick.Models;
using DapperTutorialPatrick.Models.DTOS;

namespace DapperTutorialPatrick.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SuperHeroes, SuperHeroesDTO>();
            CreateMap<SuperHeroesDTO, SuperHeroes>();
        }
    }
}
