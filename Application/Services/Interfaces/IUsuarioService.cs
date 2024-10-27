using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuarios> GetByIdAsync(Guid id);
        Task<IEnumerable<Usuarios>> GetAllAsync();
        Task AddAsync(Usuarios usuario);
        Task UpdateAsync(Usuarios usuario);
        Task DeleteAsync(Guid id);
    }
}
