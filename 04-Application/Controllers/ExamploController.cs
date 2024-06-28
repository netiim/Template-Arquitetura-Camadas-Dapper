using Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace Template_Arquitetura_Camadas_Dapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExamploController : ControllerBase
    {      
        private readonly ILogger<ExamploController> _logger;
        private readonly IExemploService _service;

        public ExamploController(ILogger<ExamploController> logger, IExemploService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        [Route("cadastrar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CadastrarExemplo([FromBody] Exemplo contato)
        {
            _logger.LogWarning("Iniciando Inserção");
            await _service.AdicionarAsync(contato);

            return Created();
        }

        [HttpGet]
        [Route("listar")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Exemplo[]))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterTodos()
        {
            IEnumerable<Exemplo> exemplos = await _service.ObterTodosAsync();

            return Ok(exemplos);
        }

        [HttpGet]
        [Route("listar/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Exemplo[]))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterPorId(int id)
        {
            Exemplo exemplos = await _service.ObterPorIdAsync(id);

            return Ok(exemplos);
        }
    }
}
