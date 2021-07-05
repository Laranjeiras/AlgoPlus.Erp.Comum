using AlgoPlus.Erp.Comum.Repositorios;
using AutoMapper;
using Zion.Common2.NotificationPattern;

namespace AlgoPlus.Erp.Comum.Servicos
{
    public class BaseServico
    {
        public readonly Contract contract = new Contract();
        public readonly IUnitOfWorkComum uow;

        public Contract Contract => contract;

        public BaseServico(IUnitOfWorkComum uow)
        {
            this.uow = uow;
        }
    }
}
