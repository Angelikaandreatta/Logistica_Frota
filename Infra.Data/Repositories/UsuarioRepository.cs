using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuarios>> GetAllAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task AddAsync(Usuarios usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Usuarios usuario)
        {
            var existingUsuario = await _context.Usuarios
                .FirstOrDefaultAsync(v => v.Nome.Contains(usuario.Nome));

            if (existingUsuario == null)
                throw new KeyNotFoundException("Usuário não encontrado.");

            existingUsuario.Email = usuario.Email;
            existingUsuario.Senha = usuario.Senha;
            existingUsuario.Acesso = usuario.Acesso;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string nome)
        {
            var usuario = await _context.Usuarios
                .Where(u => u.Nome.Contains(nome))
                .FirstOrDefaultAsync();

            if (usuario == null)
                throw new KeyNotFoundException("Nenhum usuário encontrado.");

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
