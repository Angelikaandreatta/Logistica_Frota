using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IVeiculoService
    {
        Task<Veiculos> GetByIdAsync(Guid id);
        Task<IEnumerable<Veiculos>> GetAllAsync();
        Task AddAsync(Veiculos veiculo);
        Task UpdateAsync(Veiculos veiculo);
        Task DeleteAsync(Guid id);
    }
}
