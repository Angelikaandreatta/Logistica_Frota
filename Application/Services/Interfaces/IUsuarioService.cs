using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuarios>> GetAllAsync();
        Task AddAsync(Usuarios usuario);
        Task UpdateAsync(Usuarios usuario);
        Task DeleteAsync(string nome);
    }
}
