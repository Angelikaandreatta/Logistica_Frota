using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregaController : ControllerBase
    {
        private readonly IEntregaService _entregaService;

        public EntregaController(IEntregaService entregaService)
        {
            _entregaService = entregaService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Entrega>> GetEntrega(int id)
        {
            var entrega = await _entregaService.GetByIdAsync(id);
            if (entrega == null) return NotFound();
            return Ok(entrega);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entrega>>> GetAllEntregas()
        {
            var entregas = await _entregaService.GetAllAsync();
            return Ok(entregas);
        }

        [HttpPost]
        public async Task<ActionResult<Entrega>> CreateEntrega(Entrega entrega)
        {
            await _entregaService.AddAsync(entrega);
            return CreatedAtAction(nameof(GetEntrega), new { id = entrega.Id }, entrega);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEntrega(int id, Entrega entrega)
        {
            if (id != entrega.Id) return BadRequest();
            await _entregaService.UpdateAsync(entrega);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntrega(int id)
        {
            await _entregaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
