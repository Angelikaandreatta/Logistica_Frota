using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IVeiculoService
    {
        Task<Veiculos> GetAsync(string placa);
        Task<IEnumerable<Veiculos>> GetAllAsync();
        Task AddAsync(Veiculos veiculo);
        Task UpdateAsync(Veiculos veiculo);
        Task DeleteAsync(string placa);
    }
}
