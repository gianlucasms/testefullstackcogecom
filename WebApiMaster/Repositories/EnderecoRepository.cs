using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Models;
using WebApi.Repositories;

public class EnderecoRepository : IEnderecoRepository
{
    private readonly ApplicationDbContext _context;

    public EnderecoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Endereco>> GetAllEnderecosAsync()
    {
        return await _context.Enderecos.ToListAsync();
    }

    public async Task<Endereco> GetEnderecoByIdAsync(int enderecoId)
    {
        return await _context.Enderecos.FindAsync(enderecoId);
    }

    public async Task AddEnderecoAsync(Endereco endereco)
    {
        _context.Enderecos.Add(endereco);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateEnderecoAsync(Endereco endereco)
    {
        _context.Entry(endereco).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEnderecoAsync(int enderecoId)
    {
        var endereco = await _context.Enderecos.FindAsync(enderecoId);
        _context.Enderecos.Remove(endereco);
        await _context.SaveChangesAsync();
    }
}
