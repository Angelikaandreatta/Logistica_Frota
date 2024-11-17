using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class EntregaRepository : IEntregaRepository
    {
        private readonly ApplicationDbContext _context;

        public EntregaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Entrega>> GetAllAsync()
        {
            return await _context.Entregas
                .Include(e => e.Usuario)
                .Include(e => e.Veiculo)
                .Include(e => e.Endereco_Entrega)
                .ToListAsync();
        }

        public async Task AddAsync(Entrega entrega)
        {
            var usuarioExistente = await _context.Usuarios
                                                 .FirstOrDefaultAsync(u => u.Email == entrega.Usuario.Email);

            entrega.Usuario_Id = usuarioExistente.Id;
            entrega.Usuario = usuarioExistente;

            var veiculoExistente = await _context.Veiculos.FirstOrDefaultAsync(v => v.Placa == entrega.Veiculo.Placa);
            entrega.Veiculo_Id = veiculoExistente.Id;
            entrega.Veiculo = veiculoExistente;

            var enderecoExistente = await _context.Enderecos_Entregas
                                                 .FirstOrDefaultAsync(e => e.Rua == entrega.Endereco_Entrega.Rua
                                                                   && e.Bairro == entrega.Endereco_Entrega.Bairro
                                                                   && e.Cidade == entrega.Endereco_Entrega.Cidade
                                                                   && e.Estado == entrega.Endereco_Entrega.Estado
                                                                   && e.Cep == entrega.Endereco_Entrega.Cep);

            entrega.Endereco_Id = enderecoExistente.Id;
            entrega.Endereco_Entrega = enderecoExistente;

            await _context.Entregas.AddAsync(entrega);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Entrega entrega)
        {
            var entregaExistente = await _context.Entregas
                                                 .Include(e => e.Usuario)
                                                 .FirstOrDefaultAsync(e => e.Usuario.Nome.Contains(entrega.Usuario.Nome));

            entregaExistente.Status = entrega.Status;
            entregaExistente.Estimativa_Entrega = entrega.Estimativa_Entrega;
            entregaExistente.Data_Entrega = entrega.Data_Entrega;

            _context.Entregas.Update(entregaExistente);

            await _context.SaveChangesAsync();
        }
    }
}
