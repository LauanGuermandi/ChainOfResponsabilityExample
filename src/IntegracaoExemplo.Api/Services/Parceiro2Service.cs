using IntegracaoExemplo.Api.Core;
using IntegracaoExemplo.Api.Dtos;
using IntegracaoExemplo.Api.Enums;

namespace IntegracaoExemplo.Api.Services
{
    public class Parceiro2Service : PagamentoHandler
    {
        public const Parceiros Parceiro = Parceiros.Parceiro2;

        public override string Pagar(Parceiros parceiro, PagamentoDto pagamentoDto)
        {
            if (Parceiro != parceiro)
            {
                return successor.Pagar(parceiro, pagamentoDto);
            }

            return $"Pago {pagamentoDto.Valor} do parceiro 2";
        }
    }
}
