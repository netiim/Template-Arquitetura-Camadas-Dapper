using Core.Entidades;
using Insfraestrutura.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace Template_Arquitetura_Camadas_Dapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {      
        private readonly ILogger<ExamploController> _logger;
        private readonly IProdutoRepositorio _repository;

        public ProdutoController(ILogger<ExamploController> logger, IProdutoRepositorio repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [Route("listar")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Exemplo[]))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ObterTodos()
        {
            IEnumerable<Produto> exemplos = await _repository.ObterProdutosComCategorias();

            return Ok(exemplos);
        }       
    }
}
