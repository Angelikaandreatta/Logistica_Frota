using Application.Services.Interfaces;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class EntregaService : IEntregaService
    {
        private readonly IEntregaRepository _entregaRepository;

        public EntregaService(IEntregaRepository entregaRepository)
        {
            _entregaRepository = entregaRepository;
        }

        public async Task<IEnumerable<Entrega>> GetAllAsync()
        {
            return await _entregaRepository.GetAllAsync();
        }

        public async Task AddAsync(Entrega entrega)
        {
            await _entregaRepository.AddAsync(entrega);
        }

        public async Task UpdateAsync(Entrega entrega)
        {
            await _entregaRepository.UpdateAsync(entrega);
        }
    }
}
