using InsightPro.Avaliacao.Domain.Entities;
using InsightPro.Avaliacao.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsightPro.Avaliacao.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        private readonly IAvaliacaoApplicationService _avaliacaoApplicationService;

        public AvaliacaoController(IAvaliacaoApplicationService avaliacaoApplicationService)
        {
            _avaliacaoApplicationService = avaliacaoApplicationService;
        }

        /// <summary> 
        /// Metodo para obter todos os dados de avaliacao
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces<IEnumerable<AvaliacaoEntity>>]
        public IActionResult Get()
        {
            var avaliacoes = _avaliacaoApplicationService.ObterTodasAvaliacoes();

            if(avaliacoes is not null)
                return Ok(avaliacoes);

            return BadRequest("Não foi possível obter os dados");
        }

        /// <summary>
        /// Metodo para obter uma avaliacao
        /// </summary>
        /// <param name="id">Identicador da avaliacao</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces<AvaliacaoEntity>]

        public IActionResult GetPorId(int id)
        {
            var avaliacoes = _avaliacaoApplicationService.ObterAvaliacaoPorId(id);

            if (avaliacoes is not null)
                return Ok(avaliacoes);

            return BadRequest("Não foi possível obter os dados");
        }


        /// <summary>
        /// Metodo para salvar a avaliacao
        /// </summary>
        /// <param name="entity">Modelo de dados da avaliacao</param>
        /// <returns></returns>
        [HttpPost]
        [Produces<AvaliacaoEntity>]
        public IActionResult Post(AvaliacaoEntity entity)
        {
            var avaliacoes = _avaliacaoApplicationService.SalvarDadosAvaliacao(entity);

            if (avaliacoes is not null)
                return Ok(avaliacoes);

            return BadRequest("Não foi possível obter os dados");
        }

        /// <summary>
        /// Metodo para editar a avaliacao
        /// </summary>
        /// <param name="entity">Modelo de dados da avaliacao</param>
        /// <returns></returns>
        [HttpPut]
        [Produces<AvaliacaoEntity>]
        public IActionResult Put(AvaliacaoEntity entity)
        {
            var avaliacoes = _avaliacaoApplicationService.EditarDadosAvaliacao(entity);

            if (avaliacoes is not null)
                return Ok(avaliacoes);

            return BadRequest("Não foi possível editar os dados");
        }

        /// <summary>
        /// Metodo para deletar uma avaliacao
        /// </summary>
        /// <param name="id">Identicador da avaliacao</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces<AvaliacaoEntity>]

        public IActionResult Delete(int id)
        {
            var avaliacoes = _avaliacaoApplicationService.DeletarDadosAvaliacao(id);

            if (avaliacoes is not null)
                return Ok(avaliacoes);

            return BadRequest("Não foi possível deletar os dados");
        }
    }
}
