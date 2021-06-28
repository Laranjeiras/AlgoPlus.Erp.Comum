using AlgoPlus.Erp.Comum.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgoPlus.Erp.Comum.Repositorios
{
    public interface IFormaPagamentoRepositorio
    {
        public Task SalvarAsync(FormaPagamentoModelo forma);
        public Task<IList<FormaPagamentoModelo>> ObterFormasAsync();
    }
}
