using Domain.Entities;

namespace Domain.Repositories
{
    public interface IEnderecoEntregaRepository
    {
        Task<Endereco_Entrega> GetByIdAsync(Guid id);
        Task<IEnumerable<Endereco_Entrega>> GetAllAsync();
        Task AddAsync(Endereco_Entrega enderecoEntrega);
        Task UpdateAsync(Endereco_Entrega enderecoEntrega);
        Task DeleteAsync(Guid id);
    }
}
