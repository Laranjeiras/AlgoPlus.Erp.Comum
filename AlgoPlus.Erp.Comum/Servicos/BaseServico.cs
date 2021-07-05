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
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
        public readonly IMapper mapper;
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13

        public Contract Contract => contract;

        public BaseServico(IUnitOfWorkComum uow)
        {
            this.uow = uow;
<<<<<<< HEAD
=======
            this.mapper = mapper;
=======

        public Contract Contract => contract;

        public BaseServico(IUnitOfWorkComum uow)
        {
            this.uow = uow;
>>>>>>> 75f0a6785b56515ae8c4ceb7e52f363f6681a165
<<<<<<< HEAD
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
=======
>>>>>>> 58c3cc7477366db137005ec13e6c32bb06160a13
        }
    }
}
