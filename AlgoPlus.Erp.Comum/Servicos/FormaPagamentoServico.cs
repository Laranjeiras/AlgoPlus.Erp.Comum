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
    public class FormaPagamentoServico : BaseServico
    {

        public FormaPagamentoServico(IUnitOfWorkComum uow, IMapper mapper) : base(uow, mapper)
        {
        }

        #region Forma Pagamento

        public async Task SalvarAsync(FormaPagamentoEditarDTO formaVm)
        {
            if (formaVm.TipoPgtoNFe <= 0)
                contract.AddNotification("IdPgtoNFe", "O campo IdPgtoNFe é de preenchimento obrigatório");
            if (string.IsNullOrEmpty(formaVm.Descricao))
                contract.AddNotification("Descricao", "O campo Descrição é de preenchimento obrigatório");

            var forma = new FormaPagamentoModelo
            {
                Ativo = formaVm.Ativo,
                Descricao = formaVm.Descricao,
                IdFormaPagamento = formaVm.IdFormaPagamento,
                TipoPgtoNFe = formaVm.TipoPgtoNFe
            };

            await uow.FormasPagamento.SalvarAsync(forma);
        }

        public async Task<IList<FormaPagamentoModelo>> ObterFormasAsync()
        {
            var formas = await uow.FormasPagamento.ObterFormasAsync();
            return formas;
        }

        public async Task<IList<FormaPagamentoModelo>> ObterFormasAtivasAsync()
        {
            var formas = await uow.FormasPagamento.ObterFormasAsync();
            return formas.Where(x => x.Ativo).ToList();
        }
        #endregion

        #region Prazo Pagamento
        public async Task SalvarAsync(PrazoPagamentoEditarDTO prazoVm)
        {
            if (string.IsNullOrEmpty(prazoVm.Descricao))
                contract.AddNotification("Descricao", "O campo Descrição é de preenchimento obrigatório");

            if (string.IsNullOrEmpty(prazoVm.Prazo))
                contract.AddNotification("Prazo", "O campo Prazo(s) é de preenchimento obrigatório");

            if (!Contract.Valid)
                return;

            var forma = new PrazoPagamentoModelo(prazoVm.IdPrazoPagamento, prazoVm.IdFormaPagamento, prazoVm.Descricao, prazoVm.Prazo, prazoVm.Ativo);
            await uow.PrazosPagamento.SalvarAsync(forma);
        }

        public async Task<IList<PrazoPagamentoModelo>> ObterPrazosAtivosPorFormaAsync(Guid idFormaPagamento)
        {
            var prazos = await uow.PrazosPagamento.ObterPrazosAsync(idFormaPagamento);
            return prazos.Where(x => x.Ativo).ToList();
        }

        public async Task<IList<PrazoPagamentoModelo>> ObterPrazosPorFormaAsync(Guid idFormaPagamento)
        {
            var prazos = await uow.PrazosPagamento.ObterPrazosAsync(idFormaPagamento);
            return prazos.Where(x => x.Ativo).ToList();
        }
        #endregion
    }
}
