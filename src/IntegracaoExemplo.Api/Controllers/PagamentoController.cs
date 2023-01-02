using IntegracaoExemplo.Api.Core;
using IntegracaoExemplo.Api.Dtos;
using IntegracaoExemplo.Api.Enums;
using IntegracaoExemplo.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoExemplo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly PagamentoHandler _initialHandler;

        public PagamentoController()
        {
            _initialHandler = new Parceiro1Service();
            _initialHandler.SetSuccessor(new Parceiro2Service());
        }

        [HttpPost("pagamento/{nomeParceiro}/pagar")]
        public IActionResult Pagar([FromRoute] string nomeParceiro, [FromBody] PagamentoDto pagamentoDto)
        {
            var parceiro = Enum.Parse<Parceiros>(nomeParceiro);
            var response = _initialHandler.Pagar(parceiro, pagamentoDto);
            return Ok(response);
        }
    }
}
