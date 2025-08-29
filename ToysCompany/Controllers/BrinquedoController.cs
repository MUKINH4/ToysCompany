using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToysCompany.DTO;
using ToysCompany.Models;
using ToysCompany.Services;

namespace ToysCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrinquedoController : ControllerBase
    {

        private readonly BrinquedoService _service;

        public BrinquedoController(BrinquedoService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brinquedo>>> GetBrinquedos()
        {
            var brinquedo = await _service.ListarBrinquedosAsync();

            return Ok(brinquedo);
        }

        [HttpPost]
        public async Task<ActionResult<BrinquedoDTO>> adicionar([FromBody] BrinquedoDTO brinquedo)
        {
            if (brinquedo == null) return BadRequest("Brinquedo inválido");

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var novoBrinquedo = await _service.AdicionarBrinquedo(brinquedo);

            return CreatedAtAction(nameof(GetBrinquedos), null, novoBrinquedo);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brinquedo>> GetBrinquedoPorId(int id)
        {
            var brinquedo = await _service.EncontrarBrinquedoPorId(id);
            if (brinquedo == null) return NotFound("Brinquedo não encontrado");
            return Ok(brinquedo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deletar(int id)
        {

            var brinquedo = await _service.EncontrarBrinquedoPorId(id);
            if (brinquedo == null) return NotFound("Brinquedo não encontrado");

            await _service.DeletarBrinquedo(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<BrinquedoDTO>> editar(int id, [FromBody] BrinquedoDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var brinquedo = await _service.EditarBrinquedo(id, dto);
            if (brinquedo == null) return NotFound("Brinquedo não encontrado");
            return Ok(brinquedo);
        }
    }
}
