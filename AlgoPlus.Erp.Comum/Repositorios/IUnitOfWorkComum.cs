using System.Threading.Tasks;

namespace AlgoPlus.Erp.Comum.Repositorios
{
    public interface IUnitOfWorkComum
    {
        public IPrazoPagamentoRepositorio PrazosPagamento { get; }
        public IFormaPagamentoRepositorio FormasPagamento { get; }
    }
}
