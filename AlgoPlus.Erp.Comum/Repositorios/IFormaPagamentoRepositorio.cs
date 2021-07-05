using AlgoPlus.Erp.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgoPlus.Erp.Comum.Repositorios
{
    public interface IFormaPagamentoRepositorio
    {
        Task SalvarAsync(FormaPagamentoModelo forma);
        Task<FormaPagamentoModelo> ObterFormaAsync(Guid IdFormaPagamento);
        Task<IList<FormaPagamentoModelo>> ObterFormasAsync();
        Task ExcluirAsync(Guid idPrazoPagamento);
    }
}
