using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnidadeConsumidoraController : ControllerBase
    {
        private readonly IUnidadeConsumidoraRepository _unidadeConsumidoraRepository;

        public UnidadeConsumidoraController(IUnidadeConsumidoraRepository unidadeConsumidoraRepository)
        {
            _unidadeConsumidoraRepository = unidadeConsumidoraRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnidadeConsumidora>>> GetUnidadesConsumidorasAsync()
        {
            var unidadesConsumidoras = await _unidadeConsumidoraRepository.GetAllUnidadesConsumidorasAsync();
            return Ok(unidadesConsumidoras);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UnidadeConsumidora>> GetUnidadeConsumidoraAsync(int id)
        {
            var unidadeConsumidora = await _unidadeConsumidoraRepository.GetUnidadeConsumidoraByIdAsync(id);
            if (unidadeConsumidora == null)
            {
                return NotFound();
            }

            return Ok(unidadeConsumidora);
        }

        [HttpPost]
        public async Task<ActionResult<UnidadeConsumidora>> PostUnidadeConsumidoraAsync(UnidadeConsumidora unidadeConsumidora)
        {
            await _unidadeConsumidoraRepository.AddUnidadeConsumidoraAsync(unidadeConsumidora);
            CreatedAtAction(nameof(GetUnidadeConsumidoraAsync), new { id = unidadeConsumidora.Id }, unidadeConsumidora);

            return Ok(unidadeConsumidora);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnidadeConsumidoraAsync(int id, UnidadeConsumidora unidadeConsumidora)
        {
            if (id != unidadeConsumidora.Id)
            {
                return BadRequest();
            }

            await _unidadeConsumidoraRepository.UpdateUnidadeConsumidoraAsync(unidadeConsumidora);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnidadeConsumidoraAsync(int id)
        {
            await _unidadeConsumidoraRepository.DeleteUnidadeConsumidoraAsync(id);
            return NoContent();
        }
    }
}
