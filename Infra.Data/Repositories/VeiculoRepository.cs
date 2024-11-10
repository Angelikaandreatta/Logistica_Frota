using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly ApplicationDbContext _context;

        public VeiculoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Veiculos> GetAsync(string placa)
        {
            return await _context.Veiculos
                .Where(v => v.Placa.ToLower() == placa.ToLower())
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Veiculos>> GetAllAsync()
        {
            return await _context.Veiculos.ToListAsync();
        }

        public async Task AddAsync(Veiculos veiculo)
        {
            await _context.Veiculos.AddAsync(veiculo);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Veiculos veiculo)
        {
            _context.Veiculos.Update(veiculo);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string placa)
        {
            var veiculo = await GetAsync(placa);
            if (veiculo != null)
            {
                _context.Veiculos.Remove(veiculo);
                await _context.SaveChangesAsync();
            }
        }
    }
}
