using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IEnderecoEntregaService
    {
        Task<Endereco_Entrega> GetByIdAsync(int id);
        Task<IEnumerable<Endereco_Entrega>> GetAllAsync();
        Task AddAsync(Endereco_Entrega enderecoEntrega);
        Task UpdateAsync(Endereco_Entrega enderecoEntrega);
        Task DeleteAsync(int id);
    }
}
