using System.Text.Json.Serialization;
using WebApi.Models;

namespace WebApi.DTOs
{
    public class UnidadeConsumidoraDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int Concessionaria { get; set; }
        public bool Ativo { get; set; }
        public int CooperadoId { get; set; }
        public Cooperado Cooperado { get; set; }
        public int EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
    }
}
