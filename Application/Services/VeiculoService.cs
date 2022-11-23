using Application.DTOs;
using Application.DTOs.Validations;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IMapper _mapper;

        public VeiculoService(IVeiculoRepository veiculoRepository, IMapper mapper)
        {
            _veiculoRepository = veiculoRepository;
            _mapper = mapper;
        }

        public async Task<ResultService<VeiculoDto>> Create(VeiculoDto veiculoDto)
        {
            if (veiculoDto == null)
                return ResultService.Fail<VeiculoDto>("Objeto deve ser informado");

            var result = new VeiculoDtoValidator().Validate(veiculoDto);

            if (!result.IsValid)
                return ResultService.RequestError<VeiculoDto>("Problemas de validação", result);

            var veiculo = _mapper.Map<Veiculo>(veiculoDto);
            var data = _veiculoRepository.CreateAsync(veiculo);

            return ResultService.Ok<VeiculoDto>(_mapper.Map<VeiculoDto>(data));
        }

        public async Task<ResultService> DeleteAsync(int id)
        {
            var veiculo = await _veiculoRepository.GetByIdAsync(id);

            if (veiculo == null)
                return ResultService.Fail("Veiculo não encontrado.");

            await _veiculoRepository.DeleteAsync(veiculo);
            return ResultService.Ok("Veiculo deletado.");
        }

        public async Task<ResultService<ICollection<VeiculoDto>>> GetAsync()
        {
            var veiculo = await _veiculoRepository.GetVeiculoAsync();
            return ResultService.Ok<ICollection<VeiculoDto>>(_mapper.Map<ICollection<VeiculoDto>>(veiculo));
        }

        public async Task<ResultService<VeiculoDto>> GetByIdAsync(int id)
        {
            var veiculo = await _veiculoRepository.GetByIdAsync(id);

            if (veiculo == null)
                return ResultService.Fail<VeiculoDto>("Veiculo não encontrado");

            return ResultService.Ok(_mapper.Map<VeiculoDto>(veiculo));
        }

        public async Task<ResultService> UpdateAsync(VeiculoDto veiculoDto)
        {
            if (veiculoDto == null)
                return ResultService.Fail("Objeto deve ser informado.");

            var validation = new VeiculoDtoValidator().Validate(veiculoDto);

            if (!validation.IsValid)
                return ResultService.RequestError("Problema com a validação dos campos.", validation);

            var veiculo = await _veiculoRepository.GetByIdAsync(veiculoDto.Id);
            if (veiculo == null)
                return ResultService.Fail("Veiculo não encontrado.");

            veiculo = _mapper.Map<VeiculoDto, Veiculo>(veiculoDto, veiculo);
            await _veiculoRepository.EditAsync(veiculo);

            return ResultService.Ok("Veiculo editado com sucesso.");
        }
    }
}
