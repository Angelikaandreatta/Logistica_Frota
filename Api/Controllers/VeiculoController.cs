using Application.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;

        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] VeiculoDto veiculoDto)
        {
            var result = _veiculoService.Create(veiculoDto);
            if (result.IsCompletedSuccessfully)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _veiculoService.GetAsync();

            if (result.IsSucess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var result = await _veiculoService.GetByIdAsync(id);

            if (result.IsSucess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] VeiculoDto veiculoDto)
        {
            var result = _veiculoService.UpdateAsync(veiculoDto);
            if (result.IsCompletedSuccessfully)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var result = _veiculoService.DeleteAsync(id);
            if (result.IsCompletedSuccessfully)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
