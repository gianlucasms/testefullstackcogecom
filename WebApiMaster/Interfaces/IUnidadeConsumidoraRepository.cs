using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IUnidadeConsumidoraRepository
    {
        Task<List<UnidadeConsumidora>> GetAllUnidadesConsumidorasAsync();
        Task<UnidadeConsumidora> GetUnidadeConsumidoraByIdAsync(int unidadeConsumidoraId);
        Task AddUnidadeConsumidoraAsync(UnidadeConsumidora unidadeConsumidora);
        Task UpdateUnidadeConsumidoraAsync(UnidadeConsumidora unidadeConsumidora);
        Task DeleteUnidadeConsumidoraAsync(int unidadeConsumidoraId);
    }
}
