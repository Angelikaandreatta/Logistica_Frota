using Domain.Entities;

namespace Domain.Repositories
{
    public interface IVeiculoRepository
    {
        Task<Veiculos> GetByIdAsync(Guid id);
        Task<IEnumerable<Veiculos>> GetAllAsync();
        Task AddAsync(Veiculos veiculo);
        Task UpdateAsync(Veiculos veiculo);
        Task DeleteAsync(Guid id);
    }
}
