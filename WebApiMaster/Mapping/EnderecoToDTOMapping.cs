using AutoMapper;
using WebApi.DTOs;
using WebApi.Models;

namespace WebApi.Mapping
{
    public class EnderecoToDTOMapping : Profile
    {
        public EnderecoToDTOMapping()
        {
            CreateMap<Endereco, EnderecoDTO>();
        }

    }
}
