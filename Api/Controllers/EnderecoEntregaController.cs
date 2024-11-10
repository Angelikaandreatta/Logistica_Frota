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
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEnderecoEntrega(Endereco_Entrega enderecoEntrega)
        {
            await _enderecoEntregaService.UpdateAsync(enderecoEntrega);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEnderecoEntrega(Endereco_Entrega enderecoEntrega)
        {
            await _enderecoEntregaService.DeleteAsync(enderecoEntrega);
            return NoContent();
        }
    }
}
