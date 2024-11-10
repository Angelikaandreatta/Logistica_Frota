using Domain.Entities;

namespace Domain.Repositories
{
    public interface IEntregaRepository
    {
        Task<IEnumerable<Entrega>> GetAllAsync();
        Task AddAsync(Entrega entrega);
        Task UpdateAsync(Entrega entrega);
    }
}
