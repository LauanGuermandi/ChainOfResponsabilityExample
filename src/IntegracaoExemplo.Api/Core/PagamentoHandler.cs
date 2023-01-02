using IntegracaoExemplo.Api.Dtos;
using IntegracaoExemplo.Api.Enums;

namespace IntegracaoExemplo.Api.Core
{
    public abstract class PagamentoHandler
    {
        protected PagamentoHandler successor;

        public void SetSuccessor(PagamentoHandler successor)
        {
            this.successor = successor;
        }

        public abstract string Pagar(Parceiros parceiro, PagamentoDto pagamentoDto);
    }
}
