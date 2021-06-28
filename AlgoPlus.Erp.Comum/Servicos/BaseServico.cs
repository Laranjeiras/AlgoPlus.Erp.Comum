using AlgoPlus.Erp.Comum.Repositorios;
using AutoMapper;
using Zion.Common2.NotificationPattern;

namespace AlgoPlus.Erp.Comum.Servicos
{
    public class BaseServico
    {
        public readonly Contract contract = new Contract();
        public readonly IUnitOfWorkComum uow;
        public readonly IMapper mapper;

        public Contract Contract => contract;

        public BaseServico(IUnitOfWorkComum uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
    }
}
