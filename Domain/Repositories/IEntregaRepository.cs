using Domain.Entities;

namespace Domain.Repositories
{
    public interface IEntregaRepository
    {
        Task<Entrega> GetByIdAsync(Guid id);
        Task<IEnumerable<Entrega>> GetAllAsync();
        Task AddAsync(Entrega entrega);
        Task UpdateAsync(Entrega entrega);
        Task DeleteAsync(Guid id);
    }
}
