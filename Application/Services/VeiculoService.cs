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

        public async Task<Veiculos> GetAsync(string placa)
        {
            return await _veiculoRepository.GetAsync(placa);
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

        public async Task DeleteAsync(string placa)
        {
            await _veiculoRepository.DeleteAsync(placa);
        }
    }
}
