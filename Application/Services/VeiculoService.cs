using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task<Veiculos> GetByIdAsync(Guid id)
        {
            return await _veiculoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Veiculos>> GetAllAsync()
        {
            return await _veiculoRepository.GetAllAsync();
        }

        public async Task AddAsync(Veiculos veiculo)
        {
            await _veiculoRepository.AddAsync(veiculo);
        }

        public async Task UpdateAsync(Veiculos veiculo)
        {
            await _veiculoRepository.UpdateAsync(veiculo);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _veiculoRepository.DeleteAsync(id);
        }
    }
}
