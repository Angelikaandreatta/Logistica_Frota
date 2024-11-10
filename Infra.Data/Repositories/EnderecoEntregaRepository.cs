using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class EnderecoEntregaRepository : IEnderecoEntregaRepository
    {
        private readonly ApplicationDbContext _context;

        public EnderecoEntregaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Endereco_Entrega>> GetAllAsync()
        {
            return await _context.Enderecos_Entregas.ToListAsync();
        }

        public async Task AddAsync(Endereco_Entrega enderecoEntrega)
        {
            await _context.Enderecos_Entregas.AddAsync(enderecoEntrega);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Endereco_Entrega enderecoEntrega)
        {
            var enderecoExistente = await _context.Enderecos_Entregas
                .FirstOrDefaultAsync(v => v.Rua.Contains(enderecoEntrega.Rua));

            if (enderecoExistente == null)
                throw new KeyNotFoundException("Endereço de entrega não encontrado.");

            enderecoExistente.Bairro = enderecoEntrega.Bairro;
            enderecoExistente.Cidade = enderecoEntrega.Cidade;
            enderecoExistente.Estado = enderecoEntrega.Estado;
            enderecoExistente.Cep = enderecoEntrega.Cep;

            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(Endereco_Entrega endereco_Entrega)
        {
            var enderecoEntrega = await _context.Enderecos_Entregas
                .FirstOrDefaultAsync(e => e.Rua == endereco_Entrega.Rua &&
                                          e.Bairro == endereco_Entrega.Bairro &&
                                          e.Cidade == endereco_Entrega.Cidade &&
                                          e.Estado == endereco_Entrega.Estado &&
                                          e.Cep == endereco_Entrega.Cep);
            if (enderecoEntrega == null)
                throw new KeyNotFoundException("Endereço de entrega não encontrado.");

            _context.Enderecos_Entregas.Remove(enderecoEntrega);
            await _context.SaveChangesAsync();
        }
    }
}
