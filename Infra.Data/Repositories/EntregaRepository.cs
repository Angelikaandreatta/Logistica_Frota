using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class EntregaRepository : IEntregaRepository
    {
        private readonly ApplicationDbContext _context;

        public EntregaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Entrega> GetByIdAsync(int id)
        {
            return await _context.Entregas
                .Include(e => e.Usuario)
                .Include(e => e.Veiculo)
                .Include(e => e.Endereco_Entrega)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Entrega>> GetAllAsync()
        {
            return await _context.Entregas
                .Include(e => e.Usuario)
                .Include(e => e.Veiculo)
                .Include(e => e.Endereco_Entrega)
                .ToListAsync();
        }

        public async Task AddAsync(Entrega entrega)
        {
            await _context.Entregas.AddAsync(entrega);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Entrega entrega)
        {
            _context.Entregas.Update(entrega);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entrega = await GetByIdAsync(id);
            if (entrega != null)
            {
                _context.Entregas.Remove(entrega);
                await _context.SaveChangesAsync();
            }
        }
    }
}
