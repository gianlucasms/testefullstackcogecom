using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.DTOs;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;

        public EnderecoController(IEnderecoRepository enderecoRepository, IMapper mapper)
        {
            _enderecoRepository = enderecoRepository ?? throw new ArgumentNullException(nameof(enderecoRepository));
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Endereco>>> GetEnderecosAsync()
        {
            var enderecos = await _enderecoRepository.GetAllEnderecosAsync();
            var enderecosDTO = _mapper.Map<IEnumerable<EnderecoDTO>>(enderecos);
            return Ok(enderecosDTO);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> GetEnderecoAsync(int id)
        {
            var endereco = await _enderecoRepository.GetEnderecoByIdAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }

            var enderecosDTO = _mapper.Map<IEnumerable<EnderecoDTO>>(endereco);

            return Ok(enderecosDTO);
        }

        [HttpPost]
        public async Task<ActionResult<Endereco>> PostEnderecoAsync(Endereco endereco)
        {
            await _enderecoRepository.AddEnderecoAsync(endereco);
            var enderecosDTO = _mapper.Map<IEnumerable<EnderecoDTO>>(endereco);
            CreatedAtAction(nameof(GetEnderecoAsync), new { id = endereco.Id }, endereco);

            return Ok(endereco);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnderecoAsync(int id, Endereco endereco)
        {
            if (id != endereco.Id)
            {
                return BadRequest();
            }

            await _enderecoRepository.UpdateEnderecoAsync(endereco);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEnderecoAsync(int id)
        {
            await _enderecoRepository.DeleteEnderecoAsync(id);
            return NoContent();
        }
    }
}
