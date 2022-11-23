using Domain.Entities;

namespace Domain.Repositories
{
    public interface IVeiculoRepository
    {
        Task<Veiculo> GetByIdAsync(int id);
        Task<ICollection<Veiculo>> GetVeiculoAsync();
        Task<Veiculo> CreateAsync(Veiculo veiculo);
        Task EditAsync(Veiculo veiculo);
        Task DeleteAsync(Veiculo veiculo);
    }
}
