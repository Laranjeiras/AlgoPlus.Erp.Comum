using AlgoPlus.Erp.Comum.DTOs;
using AlgoPlus.Erp.Comum.Modelos;
using AlgoPlus.Erp.Comum.Repositorios;
using AlgoPlus.Erp.Comum.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoPlus.Erp.Comum.Servicos
{
    public class FormaPagamentoServico : BaseServico
    {

        public FormaPagamentoServico(IUnitOfWorkComum uow) : base(uow)
        {
        }

        #region Forma Pagamento
        public async Task SalvarAsync(FormaPagamentoDTO formaVm)
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
                TipoPgtoNFe = formaVm.TipoPgtoNFe,
                TipoIntegracao = formaVm.TipoIntegracao,
                Duplicata = formaVm.Duplicata
            };

            await uow.FormasPagamento.SalvarAsync(forma);
        }

        public async Task<IList<FormaPagamentoDTO>> ObterFormasAsync()
        {
            var formas = await uow.FormasPagamento.ObterFormasAsync();
            var dtos = formas.Select(x => x.MapearParaDTO()).ToList();
            return dtos;
        }

        public async Task<IList<FormaPagamentoDTO>> ObterFormasAtivasAsync()
        {
            var formas = await uow.FormasPagamento.ObterFormasAsync();
            var dtos = formas.Select(x => x.MapearParaDTO()).ToList();
            return dtos.Where(x => x.Ativo).ToList();
        }
        #endregion

        #region Prazo Pagamento
        public async Task<PrazoPagamentoEditarDTO> SalvarAsync(PrazoPagamentoEditarDTO prazoVm)
        {
            if (string.IsNullOrEmpty(prazoVm.Descricao))
                contract.AddNotification("Descricao", "O campo Descrição é de preenchimento obrigatório");

            if (string.IsNullOrEmpty(prazoVm.Prazo))
                contract.AddNotification("Prazo", "O campo Prazo(s) é de preenchimento obrigatório");

            if (!Contract.Valid)
                return null;
            try
            {
                var prazo = new PrazoPagamentoModelo(prazoVm.IdPrazoPagamento, prazoVm.IdFormaPagamento, prazoVm.Descricao, prazoVm.Prazo, prazoVm.Ativo);
                await uow.PrazosPagamento.SalvarAsync(prazo);
                return prazo.MapearParaDTO();

            } 
            catch(ArgumentException ex)
            {
                contract.AddNotification("Prazo", ex.Message);
                return null;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IList<PrazoPagamentoModelo>> ObterPrazosAtivosPorFormaAsync(Guid idFormaPagamento)
        {
            var prazos = await uow.PrazosPagamento.ObterPrazosAsync(idFormaPagamento);
            return prazos.Where(x => x.Ativo).ToList();
        }

        public async Task<IList<PrazoPagamentoModelo>> ObterPrazosPorFormaAsync(Guid idFormaPagamento)
        {
            var prazos = await uow.PrazosPagamento.ObterPrazosAsync(idFormaPagamento);
            return prazos.ToList();
        }

        public async Task ExcluirPrazoAsync(Guid idPrazoPagamento)
        {
            await uow.FormasPagamento.ExcluirAsync(idPrazoPagamento);
        }
        #endregion
    }
}
