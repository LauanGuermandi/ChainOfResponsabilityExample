using IntegracaoExemplo.Api.Core;
using IntegracaoExemplo.Api.Dtos;
using IntegracaoExemplo.Api.Enums;

namespace IntegracaoExemplo.Api.Services
{
    public class Parceiro1Service : PagamentoHandler
    {
        public const Parceiros Parceiro = Parceiros.Parceiro1;

        public override string Pagar(Parceiros parceiro, PagamentoDto pagamentoDto)
        {
            if (Parceiro != parceiro)
            {
                return successor.Pagar(parceiro, pagamentoDto);
            }

            return $"Pago {pagamentoDto.Valor} do parceiro 1";
        }
    }
}
