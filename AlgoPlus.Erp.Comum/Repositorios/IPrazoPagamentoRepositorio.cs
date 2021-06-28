using AlgoPlus.Erp.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgoPlus.Erp.Comum.Repositorios
{
    public interface IPrazoPagamentoRepositorio
    {
        public Task SalvarAsync(PrazoPagamentoModelo prazo);
        public Task<IList<PrazoPagamentoModelo>> ObterPrazosAsync(Guid idFormaPagamento);
    }
}
