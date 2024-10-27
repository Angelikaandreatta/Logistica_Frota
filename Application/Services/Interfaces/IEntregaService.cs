using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IEntregaService
    {
        Task<Entrega> GetByIdAsync(Guid id);
        Task<IEnumerable<Entrega>> GetAllAsync();
        Task AddAsync(Entrega entrega);
        Task UpdateAsync(Entrega entrega);
        Task DeleteAsync(Guid id);
    }
}
