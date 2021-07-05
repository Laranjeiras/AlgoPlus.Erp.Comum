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
=======
        Task<FormaPagamentoModelo> ObterFormaAsync(Guid IdFormaPagamento);
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
        Task<IList<FormaPagamentoModelo>> ObterFormasAsync();
        Task ExcluirAsync(Guid idPrazoPagamento);
    }
}
