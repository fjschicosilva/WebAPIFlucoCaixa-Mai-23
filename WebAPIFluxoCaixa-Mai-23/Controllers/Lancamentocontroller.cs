using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebAPIFluxocaixa.Models;
using WebAPIFluxocaixa.Repository;

namespace WebAPIFluxocaixa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LancamentoController : ControllerBase
    {
        private readonly ILogger<LancamentoController> _logger;

        public LancamentoController(ILogger<LancamentoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("RetornaLancamentos")]
        public IEnumerable<Lancamentos> GetLancamentos(int id)
        {
            try
            {
                Repositorio<Lancamentos> repo = new Repositorio<Lancamentos>();
                var list = repo.Consultar().Where(l => l.IdLancamento == id || id == 0);
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpPost("RetornaLancamentosConsolidados")]
        public IEnumerable<LancamentosConsolidade> PostLancamentos()
        {
            try
            {
                Repositorio<Lancamentos> repo = new Repositorio<Lancamentos>();
                IList<Lancamentos> list;
                list = repo.ConsultarConsolidado();
                IList<LancamentosConsolidade> list2;
                list2 = list.Select(l => new LancamentosConsolidade { DataLancamento = l.DataLancamento, ValorLancamento = l.ValorLancamento }).ToList();
                return list2;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpPut("IncluirLancamento")]
        public IActionResult Put([FromBody] Lancamentos lancamento)
        {
            try
            {
                if (lancamento == null) return BadRequest();
                Repositorio<Lancamentos> repo = new Repositorio<Lancamentos>();
                repo.Inserir(lancamento);
                return Ok(lancamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AlterarLancamento")]
        public IActionResult Post([FromBody] Lancamentos lancamento)
        {
            try
            {
                if (lancamento == null) return BadRequest();
                Repositorio<Lancamentos> repo = new Repositorio<Lancamentos>();
                repo.Alterar(lancamento);
                return Ok(lancamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Excluirlancamento")]
        public IActionResult Delete([FromBody] Lancamentos lancamento)
        {
            try
            {
                if (lancamento == null) return BadRequest();
                Repositorio<Lancamentos> repo = new Repositorio<Lancamentos>();
                repo.Excluir(lancamento);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
