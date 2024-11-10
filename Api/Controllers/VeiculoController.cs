using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;

        public VeiculosController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpGet("{placa}")]
        public async Task<ActionResult<Veiculos>> GetVeiculo(string placa)
        {
            var veiculo = await _veiculoService.GetAsync(placa);
            if (veiculo == null) return NotFound();
            return Ok(veiculo);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculos>>> GetAllVeiculos()
        {
            var veiculos = await _veiculoService.GetAllAsync();
            return Ok(veiculos);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVeiculo(Veiculos veiculo)
        {
            await _veiculoService.AddAsync(veiculo);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVeiculo(int id, Veiculos veiculo)
        {
            if (id != veiculo.Id) return BadRequest();
            await _veiculoService.UpdateAsync(veiculo);
            return NoContent();
        }

        [HttpDelete("{placa}")]
        public async Task<IActionResult> DeleteVeiculo(string placa)
        {
            await _veiculoService.DeleteAsync(placa);
            return NoContent();
        }
    }
}
