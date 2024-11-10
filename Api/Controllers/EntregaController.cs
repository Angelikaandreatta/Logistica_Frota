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
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEntrega(Entrega entrega)
        {
            await _entregaService.UpdateAsync(entrega);
            return NoContent();
        }
    }
}
