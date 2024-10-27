using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuarios> GetByIdAsync(Guid id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Usuarios>> GetAllAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task AddAsync(Usuarios usuario)
        {
            await _usuarioRepository.AddAsync(usuario);
        }

        public async Task UpdateAsync(Usuarios usuario)
        {
            await _usuarioRepository.UpdateAsync(usuario);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _usuarioRepository.DeleteAsync(id);
        }
    }
}
