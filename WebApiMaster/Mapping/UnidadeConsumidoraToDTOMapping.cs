using AutoMapper;
using WebApi.DTOs;
using WebApi.Models;

namespace WebApi.Mapping
{
    public class UnidadeConsumidoraToDTOMapping : Profile
    {
        public UnidadeConsumidoraToDTOMapping()
        {
            CreateMap<UnidadeConsumidora, UnidadeConsumidoraDTO>();
        }
    }
}
