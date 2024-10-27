using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecosEntregasController : ControllerBase
    {
        private readonly IEnderecoEntregaService _enderecoEntregaService;

        public EnderecosEntregasController(IEnderecoEntregaService enderecoEntregaService)
        {
            _enderecoEntregaService = enderecoEntregaService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco_Entrega>> GetEnderecoEntrega(Guid id)
        {
            var enderecoEntrega = await _enderecoEntregaService.GetByIdAsync(id);
            if (enderecoEntrega == null) return NotFound();
            return Ok(enderecoEntrega);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Endereco_Entrega>>> GetAllEnderecosEntregas()
        {
            var enderecosEntregas = await _enderecoEntregaService.GetAllAsync();
            return Ok(enderecosEntregas);
        }

        [HttpPost]
        public async Task<ActionResult<Endereco_Entrega>> CreateEnderecoEntrega(Endereco_Entrega enderecoEntrega)
        {
            await _enderecoEntregaService.AddAsync(enderecoEntrega);
            return CreatedAtAction(nameof(GetEnderecoEntrega), new { id = enderecoEntrega.Id }, enderecoEntrega);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEnderecoEntrega(Guid id, Endereco_Entrega enderecoEntrega)
        {
            if (id != enderecoEntrega.Id) return BadRequest();
            await _enderecoEntregaService.UpdateAsync(enderecoEntrega);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnderecoEntrega(Guid id)
        {
            await _enderecoEntregaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
