using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuarios> GetByIdAsync(Guid id);
        Task<IEnumerable<Usuarios>> GetAllAsync();
        Task AddAsync(Usuarios usuario);
        Task UpdateAsync(Usuarios usuario);
        Task DeleteAsync(Guid id);
    }
}
