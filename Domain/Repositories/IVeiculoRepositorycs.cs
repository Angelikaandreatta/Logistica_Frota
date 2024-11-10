using Domain.Entities;

namespace Domain.Repositories
{
    public interface IVeiculoRepository
    {
        Task<Veiculos> GetAsync(string placa);
        Task<IEnumerable<Veiculos>> GetAllAsync();
        Task AddAsync(Veiculos veiculo);
        Task UpdateAsync(Veiculos veiculo);
        Task DeleteAsync(string placa);
    }
}
