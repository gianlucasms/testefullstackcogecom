using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class UnidadeConsumidoraRepository : IUnidadeConsumidoraRepository
    {
        private readonly ApplicationDbContext _context;

        public UnidadeConsumidoraRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<UnidadeConsumidora>> GetAllUnidadesConsumidorasAsync()
        {
            return await _context.UnidadesConsumidoras.ToListAsync();
        }

        public async Task<UnidadeConsumidora> GetUnidadeConsumidoraByIdAsync(int unidadeConsumidoraId)
        {
            return await _context.UnidadesConsumidoras.FindAsync(unidadeConsumidoraId);
        }

        public async Task AddUnidadeConsumidoraAsync(UnidadeConsumidora unidadeConsumidora)
        {
            _context.UnidadesConsumidoras.Add(unidadeConsumidora);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUnidadeConsumidoraAsync(UnidadeConsumidora unidadeConsumidora)
        {
            _context.Entry(unidadeConsumidora).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUnidadeConsumidoraAsync(int unidadeConsumidoraId)
        {
            var unidadeConsumidora = await _context.UnidadesConsumidoras.FindAsync(unidadeConsumidoraId);
            _context.UnidadesConsumidoras.Remove(unidadeConsumidora);
            await _context.SaveChangesAsync();
        }
    }
}
