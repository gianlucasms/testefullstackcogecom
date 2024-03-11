using WebApi.Models;

namespace WebApi.DTOs;

    public class CooperadoDTO
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
