using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuarios> GetByIdAsync(int id);
        Task<IEnumerable<Usuarios>> GetAllAsync();
        Task AddAsync(Usuarios usuario);
        Task UpdateAsync(Usuarios usuario);
        Task DeleteAsync(int id);
    }
}
