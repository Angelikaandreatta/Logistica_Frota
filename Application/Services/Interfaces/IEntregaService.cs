using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IEntregaService
    {
        Task<Entrega> GetByIdAsync(int id);
        Task<IEnumerable<Entrega>> GetAllAsync();
        Task AddAsync(Entrega entrega);
        Task UpdateAsync(Entrega entrega);
        Task DeleteAsync(int id);
    }
}
