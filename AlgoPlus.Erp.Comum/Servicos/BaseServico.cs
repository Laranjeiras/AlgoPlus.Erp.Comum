using AlgoPlus.Erp.Comum.Repositorios;
using AutoMapper;
using Zion.Common2.NotificationPattern;

namespace AlgoPlus.Erp.Comum.Servicos
{
    public class BaseServico
    {
        public readonly Contract contract = new Contract();
        public readonly IUnitOfWorkComum uow;
<<<<<<< HEAD
        public readonly IMapper mapper;

        public Contract Contract => contract;

        public BaseServico(IUnitOfWorkComum uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
=======

        public Contract Contract => contract;

        public BaseServico(IUnitOfWorkComum uow)
        {
            this.uow = uow;
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
        }
    }
}
