using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly ApplicationDbContext _db;

        public VeiculoRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Veiculo> CreateAsync(Veiculo veiculo)
        {
            _db.Add(veiculo);
            await _db.SaveChangesAsync();
            return veiculo;
        }

        public async Task DeleteAsync(Veiculo veiculo)
        {
            _db.Remove(veiculo);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Veiculo veiculo)
        {
            _db.Update(veiculo);
            await _db.SaveChangesAsync();
        }

        public async Task<Veiculo> GetByIdAsync(int id)
        {
            return await _db.Veiculos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Veiculo>> GetVeiculoAsync()
        {
            return await _db.Veiculos.ToListAsync();
        }
    }
}
