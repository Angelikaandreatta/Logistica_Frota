using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IEntregaService
    {
        Task<IEnumerable<Entrega>> GetAllAsync();
        Task AddAsync(Entrega entrega);
        Task UpdateAsync(Entrega entrega);
    }
}
