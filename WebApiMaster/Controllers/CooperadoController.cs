using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CooperadoController : ControllerBase
    {
        private readonly ICooperadoRepository _cooperadoRepository;
        private readonly IMapper _mapper;

        public CooperadoController(ICooperadoRepository cooperadoRepository, IMapper mapper)
        {
            _cooperadoRepository = cooperadoRepository ?? throw new ArgumentNullException(nameof(cooperadoRepository));
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cooperado>>> GetCooperadosAsync()
        {
            var cooperados = await _cooperadoRepository.GetAllCooperadosAsync();
            var cooperadosDTO = _mapper.Map<IEnumerable<CooperadoDTO>>(cooperados);
            return Ok(cooperadosDTO);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cooperado>> GetCooperadoAsync(int id)
        {
            var cooperado = await _cooperadoRepository.GetCooperadoByIdAsync(id);

            if (cooperado == null)
            {
                return NotFound();
            }

            var cooperadoDTO = _mapper.Map<CooperadoDTO>(cooperado);

            return Ok(cooperadoDTO);
        }

        [HttpPost]
        public async Task<ActionResult<Cooperado>> PostCooperadoAsync(Cooperado cooperado)
        {
            await _cooperadoRepository.AddCooperadoAsync(cooperado);
            var cooperadoDTO = _mapper.Map<CooperadoDTO>(cooperado);
            CreatedAtAction(nameof(GetCooperadoAsync), new { id = cooperado.Id }, cooperadoDTO);

            return Ok(cooperado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCooperadoAsync(int id, Cooperado cooperado)
        {
            if (id != cooperado.Id)
            {
                return BadRequest();
            }

            await _cooperadoRepository.UpdateCooperadoAsync(cooperado);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCooperadoAsync(int id)
        {
            await _cooperadoRepository.DeleteCooperadoAsync(id);

            return NoContent();
        }
    }
}
