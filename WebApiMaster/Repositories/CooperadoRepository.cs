using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class CooperadoRepository : ICooperadoRepository
    {
        private readonly ApplicationDbContext _context;

        public CooperadoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cooperado>> GetAllCooperadosAsync()
        {
            return await _context.Cooperados.ToListAsync();
        }

        public async Task<Cooperado> GetCooperadoByIdAsync(int cooperadoId)
        {
            return await _context.Cooperados.FindAsync(cooperadoId);
        }

        public async Task AddCooperadoAsync(Cooperado cooperado)
        {
            _context.Cooperados.Add(cooperado);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCooperadoAsync(Cooperado cooperado)
        {
            _context.Entry(cooperado).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCooperadoAsync(int cooperadoId)
        {
            var cooperado = await _context.Cooperados.FindAsync(cooperadoId);

            _context.Cooperados.Remove(cooperado);

            await _context.SaveChangesAsync();
        }
    }
}
