using WebApi.Models;

namespace WebApi.Repositories;

    public interface IEnderecoRepository
    {
        Task<List<Endereco>> GetAllEnderecosAsync();
        Task<Endereco> GetEnderecoByIdAsync(int enderecoId);
        Task AddEnderecoAsync(Endereco endereco);
        Task UpdateEnderecoAsync(Endereco endereco);
        Task DeleteEnderecoAsync(int enderecoId);
    }

