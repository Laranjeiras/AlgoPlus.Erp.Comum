using AlgoPlus.Erp.Comum.DTOs;
using AlgoPlus.Erp.Comum.Modelos;
using AlgoPlus.Erp.Comum.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoPlus.Erp.Comum.Servicos
{
    public class FormaPagamentoServico
    {
        private readonly IUnitOfWorkComum uow;
        private readonly IMapper mapper;

        public FormaPagamentoServico(IUnitOfWorkComum uow, IMapper mapper) 
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        public async Task SalvarAsync(PrazoPagamentoEditarDTO prazoVm)
        {
            var prazo = new PrazoPagamentoModelo(prazoVm.Id, prazoVm.IdFormaPagamento, prazoVm.Descricao, prazoVm.Prazos, prazoVm.Ativo);
            await uow.FormasPagamento.SalvarAsync(prazo);
        }

        public IList<FormaPagamentoModelo> ObterFormas()
        {
            return new List<FormaPagamentoModelo>
            {
                new FormaPagamentoModelo
                {
                    Id = new Guid("fae4da80-38e3-44ac-8f36-04a061e8c5d2"),
                    Descricao = "DEPÓSITO BANCÁRIO",
                    IdPgtoNFe = 16
                }
            };
        }

        public async Task<IList<PrazoPagamentoModelo>> ObterPrazosPorFormaAsync(Guid idFormaPagamento)
        {
            var prazos = await uow.FormasPagamento.ObterPrazosAsync(idFormaPagamento);
            return prazos.Where(x => x.Ativo).ToList();
        }
    }
}
