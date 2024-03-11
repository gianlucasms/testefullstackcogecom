using AutoMapper;
using WebApi.DTOs;
using WebApi.Models;

namespace WebApi.Mapping
{
    public class CooperadoToDTOMapping : Profile
    {
        public CooperadoToDTOMapping()
        {
            CreateMap<Cooperado, CooperadoDTO>();
        }
    }
}
