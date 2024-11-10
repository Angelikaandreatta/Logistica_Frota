using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuarios>>> GetAllUsuarios()
        {
            var usuarios = await _usuarioService.GetAllAsync();
            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<ActionResult<Usuarios>> CreateUsuario(Usuarios usuario)
        {
            await _usuarioService.AddAsync(usuario);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsuario(Usuarios usuario)
        {
            await _usuarioService.UpdateAsync(usuario);
            return NoContent();
        }

        [HttpDelete("{nome}")]
        public async Task<IActionResult> DeleteUsuario(string nome)
        {
            await _usuarioService.DeleteAsync(nome);
            return NoContent();
        }
    }
}
