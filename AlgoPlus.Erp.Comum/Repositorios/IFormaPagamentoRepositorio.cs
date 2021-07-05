using AlgoPlus.Erp.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgoPlus.Erp.Comum.Repositorios
{
    public interface IFormaPagamentoRepositorio
    {
        Task SalvarAsync(FormaPagamentoModelo forma);
<<<<<<< HEAD
<<<<<<< HEAD
        Task<FormaPagamentoModelo> ObterFormaAsync(Guid IdFormaPagamento);
=======
<<<<<<< HEAD
=======
        Task<FormaPagamentoModelo> ObterFormaAsync(Guid IdFormaPagamento);
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
=======
=======
        Task<FormaPagamentoModelo> ObterFormaAsync(Guid IdFormaPagamento);
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
        Task<IList<FormaPagamentoModelo>> ObterFormasAsync();
        Task ExcluirAsync(Guid idPrazoPagamento);
    }
}
