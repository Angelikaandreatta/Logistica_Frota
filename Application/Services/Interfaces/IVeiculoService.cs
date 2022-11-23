using Application.DTOs;

namespace Application.Services.Interfaces
{
    public interface IVeiculoService
    {
        Task<ResultService<VeiculoDto>> Create(VeiculoDto veiculoDto);
        Task<ResultService<ICollection<VeiculoDto>>> GetAsync();
        Task<ResultService<VeiculoDto>> GetByIdAsync(int id);
        Task<ResultService> UpdateAsync(VeiculoDto veiculoDto);
        Task<ResultService> DeleteAsync(int id);
    }
}
