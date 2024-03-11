using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ICooperadoRepository
    {
        Task<List<Cooperado>> GetAllCooperadosAsync();
        Task<Cooperado> GetCooperadoByIdAsync(int cooperadoId);
        Task AddCooperadoAsync(Cooperado cooperado);
        Task UpdateCooperadoAsync(Cooperado cooperado);
        Task DeleteCooperadoAsync(int cooperadoId);
    }
}
