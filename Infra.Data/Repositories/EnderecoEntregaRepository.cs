using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class EnderecoEntregaRepository : IEnderecoEntregaRepository
    {
        private readonly ApplicationDbContext _context;

        public EnderecoEntregaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Endereco_Entrega> GetByIdAsync(int id)
        {
            return await _context.Enderecos_Entregas.FindAsync(id);
        }

        public async Task<IEnumerable<Endereco_Entrega>> GetAllAsync()
        {
            return await _context.Enderecos_Entregas.ToListAsync();
        }

        public async Task AddAsync(Endereco_Entrega enderecoEntrega)
        {
            await _context.Enderecos_Entregas.AddAsync(enderecoEntrega);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Endereco_Entrega enderecoEntrega)
        {
            _context.Enderecos_Entregas.Update(enderecoEntrega);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var enderecoEntrega = await GetByIdAsync(id);
            if (enderecoEntrega != null)
            {
                _context.Enderecos_Entregas.Remove(enderecoEntrega);
                await _context.SaveChangesAsync();
            }
        }
    }
}
