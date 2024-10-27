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

        [HttpGet("{id}")]
        public async Task<ActionResult<Veiculos>> GetVeiculo(Guid id)
        {
            var veiculo = await _veiculoService.GetByIdAsync(id);
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
        public async Task<ActionResult<Veiculos>> CreateVeiculo(Veiculos veiculo)
        {
            await _veiculoService.AddAsync(veiculo);
            return CreatedAtAction(nameof(GetVeiculo), new { id = veiculo.Id }, veiculo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVeiculo(Guid id, Veiculos veiculo)
        {
            if (id != veiculo.Id) return BadRequest();
            await _veiculoService.UpdateAsync(veiculo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVeiculo(Guid id)
        {
            await _veiculoService.DeleteAsync(id);
            return NoContent();
        }
    }
}
