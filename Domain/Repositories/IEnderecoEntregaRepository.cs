using Domain.Entities;

namespace Domain.Repositories
{
    public interface IEnderecoEntregaRepository
    {
        Task<IEnumerable<Endereco_Entrega>> GetAllAsync();
        Task AddAsync(Endereco_Entrega enderecoEntrega);
        Task UpdateAsync(Endereco_Entrega enderecoEntrega);
        Task DeleteAsync(Endereco_Entrega enderecoEntrega);
    }
}
